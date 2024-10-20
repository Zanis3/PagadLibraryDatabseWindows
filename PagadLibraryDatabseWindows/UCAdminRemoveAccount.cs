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
    public partial class UCAdminRemoveAccount : UserControl
    {
        public UCAdminRemoveAccount()
        {
            InitializeComponent();
            loadUserData("SELECT * FROM [User]");
            cboSearchOptions.SelectedItem = "UserName";
            tblViewAccounts.CellClick += tblViewAccounts_CellClick;
        }

        private void tblViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewAccounts.Rows[e.RowIndex];
                string userID = selectedRow.Cells["UserID"].Value.ToString();

                SqlConnection conn = new SqlConnection(Extra.connectionString);

                //REMOVE ACCOUNT HERE
                try
                {
                    conn.Open();

                    SqlCommand searchUser = new SqlCommand("SELECT * FROM [User] WHERE UserID = @userid", conn);
                    string username = "";
                    string usertype = "";

                    searchUser.Parameters.AddWithValue("@userid", userID);
                    SqlDataReader reader = searchUser.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        username = reader["UserName"].ToString();
                        usertype = reader["UserType"].ToString();
                    }
                    reader.Close();

                    DialogResult deleteUser = MessageBox.Show($"Do you want to delete {usertype} '{username}? This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (deleteUser == DialogResult.Yes)
                    {
                        SqlCommand removeUser = new SqlCommand("DELETE FROM [User] WHERE UserID = @userid", conn);
                        removeUser.Parameters.AddWithValue("@userid", userID);
                        removeUser.ExecuteNonQuery();
                        MessageBox.Show($"{usertype} account {username} has been deleted from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' deleted {usertype} account {username}");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            string searchQuery = txtSearchBar.Text;
            string searchSort = cboSearchOptions.SelectedItem?.ToString();
            if ((string.IsNullOrWhiteSpace(searchQuery) || searchQuery.Length < 3) && searchSort != "UserID")
            {
                MessageBox.Show($"Search query too short, please try again. (Length must be 3 characters or more)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (searchSort == "UserName")
                {
                    query = "SELECT * FROM [User] WHERE UserName LIKE @searchvalue";
                }
                else if (searchSort == "UserType")
                {
                    query = "SELECT * FROM [User] WHERE UserType LIKE @searchvalue";
                }
                else if (searchSort == "UserID")
                {
                    query = "SELECT * FROM [User] WHERE UserID = @searchvalue";
                }

                if (searchSort != "UserID")
                {
                    searchQuery = "%" + searchQuery + "%";
                }

                loadUserData(query, searchQuery);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
            cboSearchOptions.SelectedItem = "UserName";
            loadUserData("SELECT * FROM [User]");
        }

        private void loadUserData(string query, string searchValue = null)
        {
            tblViewAccounts.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            string searchQuery = txtSearchBar.Text;

            try
            {
                conn.Open();
                SqlCommand viewAllUsers = new SqlCommand(query, conn);
                viewAllUsers.Parameters.AddWithValue("@searchvalue", searchQuery);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllUsers);
                DataTable userData = new DataTable();
                dataAdapter.Fill(userData);

                if (userData.Rows.Count > 0)
                {
                    tblViewAccounts.DataSource = userData;

                    if (tblViewAccounts.Columns.Contains("UserPassword"))
                    {
                        tblViewAccounts.Columns["UserPassword"].Visible = false;
                    }
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
