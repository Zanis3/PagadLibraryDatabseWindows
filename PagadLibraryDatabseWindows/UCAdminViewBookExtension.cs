using System;
using System.Collections;
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
    public partial class UCAdminViewBookExtension : Form
    {
        private string bookID = "";
        public UCAdminViewBookExtension()
        {
            InitializeComponent();
        }

        public UCAdminViewBookExtension(string id) : this()
        {
            this.bookID = id;
            loadBookData();
        }

        public void loadBookData()
        {
            tblShowBookCopies.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                SqlCommand viewSelectedBookCopies = new SqlCommand("SELECT c.BookCopyID, c.BookID, b.BookName, CASE WHEN c.BookCopyAvailability = 1 THEN 'Available' ELSE 'Not Available' FROM BookCopy c LEFT JOIN Book b ON c.BookID = b.BookID WHERE c.BookID = @bookid", conn);

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
