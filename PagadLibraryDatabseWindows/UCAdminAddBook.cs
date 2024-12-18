﻿using System;
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
    public partial class UCAdminAddBook : UserControl
    {
        public UCAdminAddBook()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the selection?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                txtBookName.Text = "";
                txtBookAuthor.Text = "";
                txtBookISBN.Text = "";
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int counter = 0;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            //EMPTY UNG TEXT FIELDS
            if (string.IsNullOrEmpty(txtBookName.Text) || string.IsNullOrEmpty(txtBookAuthor.Text) || string.IsNullOrEmpty(txtBookISBN.Text)) 
            {
                Extra.showWarningMessage("Some text fields are empty. Please Try Again.");
            }
            else
            {
                counter++;
            }

            //IF LESS THAN 2 UNG BOOK NAME
            if(txtBookName.Text != null && txtBookName.Text.Length < 2)
            {
                Extra.showWarningMessage("Invalid Book Name. Please try again.");
            }
            else
            {
                counter++;
            }

            //IF LESS THAN 3 UNG BOOK AUTHOR
            if (txtBookAuthor.Text != null && txtBookAuthor.Text.Length < 3)
            {
                Extra.showWarningMessage("Invalid Book Author. Please try again.");
            }
            else
            {
                counter++;
            }

            //IF ISBN IS NOT EXACTLY 10
            if (txtBookISBN.Text != null && (txtBookISBN.Text.Length < 10 || txtBookISBN.Text.Length > 10))
            {
                Extra.showWarningMessage("Invalid ISBN. Please try again. (MUST BE 10 CHARACTERS OR LONG)");
            }
            else
            {
                counter++;
            }

            //IF MAY BOOK NAME AT BOOK AUTHOR NA MAGKAPAREHAS NA
            if(txtBookName.Text != null && txtBookAuthor.Text != null)
            {
                try
                {
                    conn.Open();

                    SqlCommand findBook = new SqlCommand("SELECT * FROM [Book] WHERE BookName = @bookName", conn);

                    findBook.Parameters.AddWithValue("@bookName", txtBookName.Text);

                    SqlDataReader reader = findBook.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string author = reader["BookAuthor"].ToString();

                        if(author == txtBookAuthor.Text)
                        {
                            Extra.showWarningMessage($"There is already a book named {txtBookName.Text} by {txtBookAuthor.Text}. Please try again.");
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
                catch(Exception ex)
                {
                    Extra.showException(ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            if(counter == 5)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to add the book '{txtBookName.Text}'? You will not be able to undo these changes.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        //ADD BOOK
                        SqlCommand addBook = new SqlCommand("INSERT INTO Book (BookName, BookAuthor, BookISBN) VALUES (@bookname, @bookauthor, @bookisbn)", conn);

                        addBook.Parameters.AddWithValue("@bookname", txtBookName.Text);
                        addBook.Parameters.AddWithValue("@bookauthor", txtBookAuthor.Text);
                        addBook.Parameters.AddWithValue("@bookisbn", txtBookISBN.Text);

                        addBook.ExecuteNonQuery();


                        //GET BOOK ID
                        int bookID = -1;

                        SqlCommand getBook = new SqlCommand("SELECT TOP 1 BookID FROM Book WHERE BookName = @bookname AND BookAuthor = @bookauthor", conn);

                        getBook.Parameters.AddWithValue("@bookname", txtBookName.Text);
                        getBook.Parameters.AddWithValue("@bookauthor", txtBookAuthor.Text);

                        SqlDataReader reader = getBook.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            bookID = Convert.ToInt16(reader["BookID"]);
                        }

                        reader.Close();

                        //ADD BOOK COPY
                        for (int i = 0; i < txtCopyAmount.Value; i++)
                        {
                            SqlCommand addBookCopy = new SqlCommand("INSERT INTO BookCopy (BookID) VALUES (@bookID)", conn);

                            addBookCopy.Parameters.AddWithValue("@bookID", bookID);
                            addBookCopy.ExecuteNonQuery();
                        }

                        Extra.showSucessMessage($"Book {txtBookName.Text} by {txtBookAuthor.Text} has been added!");

                        Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' added book '{txtBookName.Text}' by {txtBookAuthor.Text} to the database.");
                    }
                    catch (Exception ex)
                    {
                        Extra.showException(ex);
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