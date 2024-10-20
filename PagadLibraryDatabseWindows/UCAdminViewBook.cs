using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UCAdminViewBook : UserControl
    {
        private UCAdminViewBookExtension viewBookDetails;
        public UCAdminViewBook()
        {
            InitializeComponent();
            tblViewBooks.AutoGenerateColumns = true;
            loadBookData("SELECT b.BookID, b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID GROUP BY b.BookID, b.BookName, b.BookAuthor, b.BookISBN");
            cboSearchOptions.SelectedItem = "BookName";
            tblViewBooks.CellClick += tblViewBooks_CellClick;
        }

        private void tblViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewBooks.Rows[e.RowIndex];
                string bookID = selectedRow.Cells["BookID"].Value.ToString();

                if (viewBookDetails == null || viewBookDetails.IsDisposed)
                {
                    viewBookDetails = new UCAdminViewBookExtension(bookID);
                    viewBookDetails.ShowDialog();
                    viewBookDetails.BringToFront();
                    viewBookDetails.Focus();
                }
                else
                {
                    viewBookDetails.Close();
                    viewBookDetails = new UCAdminViewBookExtension(bookID);
                    viewBookDetails.ShowDialog();
                    viewBookDetails.BringToFront();
                    viewBookDetails.Focus();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            string searchQuery = txtSearchBar.Text;
            string searchSort = cboSearchOptions.SelectedItem?.ToString();
            if((string.IsNullOrWhiteSpace(searchQuery) || searchQuery.Length < 3) && searchSort != "BookID")
            {
                MessageBox.Show($"Search query too short, please try again. (Length must be 3 characters or more)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(searchSort == "BookName")
                {
                    query = "SELECT b.BookID, b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID WHERE b.BookName LIKE @searchvalue GROUP BY b.BookID, b.BookName, b.BookAuthor, b.BookISBN";
                }
                else if(searchSort == "BookAuthor")
                {
                    query = "SELECT b.BookID, b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID WHERE b.BookAuthor LIKE @searchvalue GROUP BY b.BookID, b.BookName, b.BookAuthor, b.BookISBN";
                }
                else if(searchSort == "BookID")
                {
                    query = "SELECT b.BookID, b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID WHERE b.BookID = @searchvalue GROUP BY b.BookID, b.BookName, b.BookAuthor, b.BookISBN";
                }

                if (searchSort != "BookID")
                {
                    searchQuery = "%" + searchQuery + "%";
                }

                loadBookData(query, searchQuery);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
            cboSearchOptions.SelectedItem = "BookName";
            loadBookData("SELECT b.BookID, b.BookName, b.BookAuthor, b.BookISBN, COUNT(c.BookCopyID) AS NumberOfCopies FROM Book b LEFT JOIN BookCopy c ON b.BookID = c.BookID GROUP BY b.BookID, b.BookName, b.BookAuthor, b.BookISBN");
        }

        private void loadBookData(string query, string searchValue = null)
        {
            tblViewBooks.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            string searchQuery = txtSearchBar.Text;

            try
            {
                conn.Open();
                SqlCommand viewAllBooks = new SqlCommand(query, conn);
                viewAllBooks.Parameters.AddWithValue("@searchvalue", searchQuery);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllBooks);
                DataTable bookData = new DataTable();
                dataAdapter.Fill(bookData);

                if (bookData.Rows.Count > 0)
                {
                    tblViewBooks.DataSource = bookData;
                }
                else
                {
                    MessageBox.Show("No data found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tblViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
