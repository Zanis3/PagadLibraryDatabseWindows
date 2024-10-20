using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UCAdminEditBookExtension : Form
    {
        private string bookID = "";
        private int bookCopies = -1;
        public UCAdminEditBookExtension()
        {
            InitializeComponent();
        }

        public UCAdminEditBookExtension(string id) : this()
        {
            this.bookID = id;
            loadBookData();
        }

        private void loadBookData()
        {
            string bookName = "";
            string bookAuthor = "";
            string bookISBN = "";

            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand searchBook = new SqlCommand("SELECT b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID WHERE b.BookID = @bookID GROUP BY b.BookName, b.BookAuthor, b.BookISBN", conn);

                searchBook.Parameters.AddWithValue("@bookID", bookID);

                SqlDataReader reader = searchBook.ExecuteReader();

                if (reader.Read())
                {
                    bookName = reader["BookName"].ToString();
                    bookAuthor = reader["BookAuthor"].ToString();
                    bookISBN = reader["BookISBN"].ToString();
                    bookCopies = Convert.ToInt16(reader["NumberOfCopies"]);
                }

                txtBookName.Text = bookName;
                txtBookAuthor.Text = bookAuthor;
                txtBookISBN.Text = bookISBN;
                txtCopyAmount.Value = bookCopies;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Something went wrong. Please try again. ({ex})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int counter = 0;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            //EMPTY UNG TEXT FIELDS
            if (string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtBookAuthor.Text) || string.IsNullOrEmpty(txtBookISBN.Text))
            {
                MessageBox.Show("Some text fields are empty. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter++;
            }

            //IF LESS THAN 2 UNG BOOK NAME
            if (txtBookName.Text != null && txtBookName.Text.Length < 2)
            {
                MessageBox.Show("Invalid Book Name. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter++;
            }

            //IF LESS THAN 3 UNG BOOK AUTHOR
            if (txtBookAuthor.Text != null && txtBookAuthor.Text.Length < 3)
            {
                MessageBox.Show("Invalid Book Author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter++;
            }

            //IF ISBN IS NOT EXACTLY TEN
            if (txtBookISBN.Text != null && (txtBookISBN.Text.Length < 10 || txtBookISBN.Text.Length > 10))
            {
                MessageBox.Show("Invalid ISBN. Please try again. (MUST BE 10 CHARACTERS OR LONG)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter++;
            }

            //IF MAY BOOK NAME AT BOOK AUTHOR NA MAGKAPAREHAS NA
            if (txtBookName.Text != null && txtBookAuthor.Text != null)
            {
                try
                {
                    conn.Open();

                    SqlCommand findBook = new SqlCommand("SELECT * FROM [Book] WHERE BookName = @bookName AND BookID != @bookID", conn);

                    findBook.Parameters.AddWithValue("@bookName", txtBookName.Text);
                    findBook.Parameters.AddWithValue("@bookID", bookID);

                    SqlDataReader reader = findBook.ExecuteReader();

                    if (reader.Read())
                    {
                        string author = reader["BookAuthor"].ToString();

                        if (author == txtBookAuthor.Text)
                        {
                            MessageBox.Show($"There is already a book named {txtBookName.Text} by {txtBookAuthor.Text}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        counter++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong. Please try again. ({ex})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            if(counter == 5)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to proceed with the changes? You will not be able to undo these changes.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        //UPDATE BOOK TABLE
                        SqlCommand editBook = new SqlCommand("UPDATE Book SET BookName = @bookname, BookAuthor = @bookAuthor, BookISBN = @bookisbn WHERE BookID = @bookid", conn);

                        editBook.Parameters.AddWithValue("@bookname", txtBookName.Text);
                        editBook.Parameters.AddWithValue("@bookAuthor", txtBookAuthor.Text);
                        editBook.Parameters.AddWithValue("@bookisbn", txtBookISBN.Text);
                        editBook.Parameters.AddWithValue("@bookid", bookID);

                        //UPDATE BOOK COPY (INCREASE OR DECREASE AMOUNT)
                        if(bookCopies < txtCopyAmount.Value)
                        {
                            //ADD BOOK COPIES
                            int addCopies = (int)txtCopyAmount.Value - bookCopies;

                            for(int i = 0; i < addCopies; i++)
                            {
                                SqlCommand addCopy = new SqlCommand("INSERT INTO BookCopy (BookID) VALUES (@bookID)", conn);
                                addCopy.Parameters.AddWithValue("@bookID", bookID);
                                addCopy.ExecuteNonQuery();
                            }
                        }
                        else if(bookCopies > txtCopyAmount.Value)
                        {
                            //REMOVE BOOK COPIES

                            //COUNT AVAILABLE COPIES (BOOKS NA DI NA BORROW)
                            SqlCommand countAvailableCopies = new SqlCommand("SELECT COUNT(*) FROM BookCopy WHERE BookID = @bookID AND BookCopyAvailability = 1", conn);
                            countAvailableCopies.Parameters.AddWithValue("@bookID", bookID);
                            int availableCount = (int)countAvailableCopies.ExecuteScalar();

                            int removeCopies = bookCopies - (int)txtCopyAmount.Value;

                            //IF REMOVE COPIES IS MORE THAN THE AVAILABLE COPIES (MEANING UNG MGA BOOK NA DI BORROWED NG IBANG USER), THEN ERROR...
                            if(removeCopies > availableCount)
                            {
                                MessageBox.Show($"You cannot delete {removeCopies} copies because there are only {availableCount} available to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                DialogResult deleteConfirmation = MessageBox.Show($"You are about to delete {removeCopies} copies. Do you want to continue?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (deleteConfirmation == DialogResult.Yes)
                                {
                                    for (int i = 0; i < removeCopies; i++)
                                    {
                                        SqlCommand removeCopy = new SqlCommand("DELETE TOP (1) FROM BookCopy WHERE BookID = @bookID AND BookCopyAvailability = 1", conn);
                                        removeCopy.Parameters.AddWithValue("@bookID", bookID);
                                        removeCopy.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        DialogResult finishEdit = MessageBox.Show($"Book {txtBookName.Text} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (finishEdit == DialogResult.OK)
                        {
                            Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' edited book '{txtBookName.Text}'.");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Something went wrong. Please try again. ({ex})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}