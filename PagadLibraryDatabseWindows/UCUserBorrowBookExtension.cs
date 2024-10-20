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
    public partial class UCUserBorrowBookExtension : Form
    {
        private SqlConnection conn = new SqlConnection(Extra.connectionString);
        private string bookID = "";
        public UCUserBorrowBookExtension()
        {
            InitializeComponent();
        }

        public UCUserBorrowBookExtension(string id) : this()
        {
            this.bookID = id;
            loadBookData();
            tblShowBookCopies.CellClick += tblShowBookCopies_CellClick;
        }

        private void tblShowBookCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblShowBookCopies.Rows[e.RowIndex];
                string copyID = selectedRow.Cells["BookCopyID"].Value.ToString();

                loadBookCopy(copyID);
            }
        }

        public void loadBookCopy(string id)
        {
            try
            {
                conn.Open();

                bool isBookCopyAvailable = false;

                SqlCommand bookCopyQuery = new SqlCommand("SELECT * FROM BookCopy WHERE BookCopyID = @bookcopyid", conn);
                bookCopyQuery.Parameters.AddWithValue("@bookcopyid", id);

                SqlDataReader reader = bookCopyQuery.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    isBookCopyAvailable = Convert.ToBoolean(reader["BookCopyAvailability"]);

                    reader.Close();
                }

                if (isBookCopyAvailable)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to borrow the book copy?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(result == DialogResult.Yes)
                    {
                        //EDIT BOOK AVAILABILITY AT BookCopy TABLE
                        SqlCommand editBookCopy = new SqlCommand("UPDATE BookCopy SET BookCopyAvailability = @copyavailability WHERE BookCopyID = @copyid", conn);
                        editBookCopy.Parameters.AddWithValue("@copyavailability", 0);
                        editBookCopy.Parameters.AddWithValue("@copyid", id);

                        editBookCopy.ExecuteNonQuery();

                        //INSERT BOOK BORROW INFORMATION AT BookBorrow TABLE
                        SqlCommand bookBorrowData = new SqlCommand("INSERT INTO BookBorrow (BookCopyID, UserID, BorrowStatus) VALUES (@bookcopyid, @userid, @borrowstatus)", conn);
                        bookBorrowData.Parameters.AddWithValue("@bookcopyid", id);
                        bookBorrowData.Parameters.AddWithValue("@userid", Session.sessionUserID);
                        bookBorrowData.Parameters.AddWithValue("@borrowstatus", "ongoing");

                        bookBorrowData.ExecuteNonQuery();

                        DialogResult borrowConfirm = MessageBox.Show("Borrow Book Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(borrowConfirm == DialogResult.OK)
                        {
                            loadBookData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The book is not available at the moment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        public void loadBookData()
        {
            tblShowBookCopies.DataSource = null;

            try
            {
                conn.Open();
                SqlCommand viewSelectedBookCopies = new SqlCommand("SELECT c.BookCopyID, c.BookID, b.BookName, CASE WHEN c.BookCopyAvailability = 1 THEN 'Available' ELSE 'Not Available' END AS Availability FROM BookCopy c LEFT JOIN Book b ON c.BookID = b.BookID WHERE c.BookID = @bookid", conn);

                viewSelectedBookCopies.Parameters.AddWithValue("@bookid", bookID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewSelectedBookCopies);
                DataTable bookData = new DataTable();
                dataAdapter.Fill(bookData);

                if (bookData.Rows.Count > 0)
                {
                    tblShowBookCopies.DataSource = bookData;
                }
                else
                {
                    MessageBox.Show("No data found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
