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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PagadLibraryDatabseWindows
{
    public partial class UCAdminUserEditAccount : UserControl
    {
        private SqlConnection conn = new SqlConnection(Extra.connectionString);
        public UCAdminUserEditAccount()
        {
            InitializeComponent();
            loadAccountData();
        }

        private void loadAccountData()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            Password pass = new Password();

            try
            {
                conn.Open();

                SqlCommand loadAccount = new SqlCommand("SELECT * FROM [User] WHERE UserID = @userid", conn);

                loadAccount.Parameters.AddWithValue("@userid", Session.sessionUserID);

                SqlDataReader reader = loadAccount.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    txtEditUsername.Text = reader["UserName"].ToString();
                }
                reader.Close();
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

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            int counter = 0;

            //IF NULL VALUES SA USERNAME AND CONFIRM PASSWORD FIELDS
            if (txtEditUsername.Text == null || txtConfirmPassword.Text == null)
            {
                MessageBox.Show("Some fields are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                counter++;
            }

            //IF USERNAME < 5
            if(txtEditUsername.Text.Length < 5 && txtEditUsername.Text != null)
            {
                MessageBox.Show("Username less than five characters long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                counter++;
            }

            //IF USERNAME > 50
            if (txtEditUsername.Text.Length > 50)
            {
                MessageBox.Show("Username greater than fifty characters long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                counter++;
            }

            //IF MERON NANG USERNAME
            if (txtEditUsername.Text != null)
            {
                string username = txtEditUsername.Text;
                conn.Open();
                SqlCommand findUsername = new SqlCommand("SELECT * FROM [User] WHERE UserName = @username AND UserID != @userid", conn);

                findUsername.Parameters.AddWithValue("@username", username);
                findUsername.Parameters.AddWithValue("@userid", Session.sessionUserID);

                SqlDataReader reader = findUsername.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show($"Username '{username}' is already taken. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                }
                else
                {
                    counter++;
                }

                conn.Close();
            }

            if(counter == 4)
            {
                int subcounter = 0;
                if(string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    try
                    {
                        conn.Open();

                        //VERIFY HASH PASSWORD AND CONFIRM PASSWORD
                        string hashPass = "";

                        SqlCommand searchQuery = new SqlCommand("SELECT * FROM [User] WHERE UserID = @userid", conn);
                        searchQuery.Parameters.AddWithValue("@userid", Session.sessionUserID);

                        SqlDataReader reader = searchQuery.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            hashPass = reader["UserPassword"].ToString();
                        }
                        reader.Close();

                        bool passVerify = Password.hashVerifier(hashPass, txtConfirmPassword.Text);

                        if (passVerify == false)
                        {
                            MessageBox.Show($"Confirm password doesn't match with your current password. Please try again.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to make these changes?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                SqlCommand editAccount = new SqlCommand("UPDATE [User] SET UserName = @username, UserPassword = @password WHERE UserID = @userid", conn);

                                editAccount.Parameters.AddWithValue("@userid", Session.sessionUserID);
                                editAccount.Parameters.AddWithValue("@username", txtEditUsername.Text);

                                string newPass = Password.passwordHasher(txtNewPassword.Text);
                                editAccount.Parameters.AddWithValue("@password", newPass);

                                editAccount.ExecuteNonQuery();
                            }

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
                else
                {
                    //IF NEW PASSWORD LENGTH < 8
                    if (txtNewPassword.Text.Length < 8)
                    {
                        MessageBox.Show($"Your new password is less than eight characters long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        subcounter++;
                    }

                    //IF NEW PASSWORD LENGTH > 255
                    if (txtNewPassword.Text.Length > 255)
                    {
                        MessageBox.Show($"Your new password is greater than 255 characters long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        subcounter++;
                    }

                    //IF NEW PASSWORD AND CONFIRM PASSWORD IS NOT ALIKE
                    if (txtNewPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show($"Your new password doesn't match confirm password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        subcounter++;
                    }

                    if (subcounter == 3)
                    {
                        try
                        {
                            conn.Open();

                            DialogResult result = MessageBox.Show("Are you sure you want to make these changes?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                SqlCommand editAccount = new SqlCommand("UPDATE [User] SET UserName = @username, UserPassword = @password WHERE UserID = @userid", conn);

                                editAccount.Parameters.AddWithValue("@userid", Session.sessionUserID);
                                editAccount.Parameters.AddWithValue("@username", txtEditUsername.Text);

                                string hashPass = Password.passwordHasher(txtNewPassword.Text);
                                editAccount.Parameters.AddWithValue("@password", hashPass);

                                editAccount.ExecuteNonQuery();
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

                MessageBox.Show("Account details edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Extra.log($"{Session.sessionUserType} '{txtEditUsername.Text}' edited their profile.");
                loadAccountData();
            }
        }

        private void btnClearChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear the changes you've made?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                loadAccountData();
                txtNewPassword.Text = null;
                txtConfirmPassword.Text = null;
            }
        }
    }
}
