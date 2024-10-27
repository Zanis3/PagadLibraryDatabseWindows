using System;
using System.Data;
using System.Data.SqlClient;
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
                Extra.showWarningMessage("Search query too short, please try again. (Length must be 3 characters or more)");
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
                    Extra.showNoticeMessage("No data found.");
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
    }
}
