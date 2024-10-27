using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UCUserReturnBook : UserControl
    {
        public UCUserReturnBook()
        {
            InitializeComponent();
            tblViewBooks.AutoGenerateColumns = true;
            loadBookData("SELECT bb.BookBorrowID, bb.BookCopyID, b.BookName FROM BookBorrow bb JOIN BookCopy bc ON bb.BookCopyID = bc.BookCopyID JOIN Book b ON bc.BookID = b.BookID WHERE UserID = @userid AND BorrowStatus = @borrowstatus");
            tblViewBooks.CellClick += tblViewBooks_CellClick;
        }

        private void tblViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewBooks.Rows[e.RowIndex];
                string bookBorrowID = selectedRow.Cells["BookBorrowID"].Value.ToString();

                //RETURN BOOK HERE
                SqlConnection conn = new SqlConnection(Extra.connectionString);

                try
                {
                    conn.Open();

                    DialogResult result = MessageBox.Show("Are you sure you want to return the book?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(result == DialogResult.Yes)
                    {
                        //SEARCH THE ROW AFFECTED IN BOOKBORROW WAHA NAKAKABALIW
                        SqlCommand searchBookBorrow = new SqlCommand("SELECT * FROM BookBorrow WHERE BookBorrowID = @bookborrowid", conn);

                        searchBookBorrow.Parameters.AddWithValue("@bookborrowid", bookBorrowID);

                        int bookCopyID = -1;
                        string borrowStatus = "";

                        SqlDataReader reader = searchBookBorrow.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            borrowStatus = reader["BorrowStatus"].ToString();
                            bookCopyID = Convert.ToInt16(reader["BookCopyID"]);
                        }
                        reader.Close();

                        //UPDATE BOOK COPY TABLE
                        SqlCommand updateBookCopy = new SqlCommand("UPDATE BookCopy SET BookCopyAvailability = @bookcopyavailability WHERE BookCopyID = @bookcopyid", conn);
                        updateBookCopy.Parameters.AddWithValue("@bookcopyAvailability", 1);
                        updateBookCopy.Parameters.AddWithValue("@bookcopyid", bookCopyID);
                        updateBookCopy.ExecuteNonQuery();

                        //UPDATE BOOK BORROW TABLE
                        SqlCommand updateBookBorrow = new SqlCommand("UPDATE BookBorrow SET BorrowStatus = @borrowstatus WHERE BookBorrowID = @bookborrowid", conn);
                        updateBookBorrow.Parameters.AddWithValue("@borrowstatus", "returned");
                        updateBookBorrow.Parameters.AddWithValue("@bookborrowid", bookBorrowID);
                        updateBookBorrow.ExecuteNonQuery();

                        DialogResult showResult = MessageBox.Show("Returned book successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(showResult == DialogResult.OK)
                        {
                            loadBookData("SELECT bb.BookBorrowID, bb.BookCopyID, b.BookName FROM BookBorrow bb JOIN BookCopy bc ON bb.BookCopyID = bc.BookCopyID JOIN Book b ON bc.BookID = b.BookID WHERE UserID = @userid AND BorrowStatus = @borrowstatus");
                            Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' returned a book they borrowed.");
                        }
                    }
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
        private void loadBookData(string query)
        {
            tblViewBooks.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                SqlCommand viewAllBooks = new SqlCommand(query, conn);
                viewAllBooks.Parameters.AddWithValue("@userid", Session.sessionUserID);
                viewAllBooks.Parameters.AddWithValue("@borrowstatus", "ongoing");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllBooks);
                DataTable bookData = new DataTable();
                dataAdapter.Fill(bookData);

                if (bookData.Rows.Count > 0)
                {
                    tblViewBooks.DataSource = bookData;
                }
                else
                {
                    Extra.showNoticeMessage("You haven't borrowed any books yet.");
                }
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
