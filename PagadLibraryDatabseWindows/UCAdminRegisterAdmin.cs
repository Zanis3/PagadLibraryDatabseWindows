using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UCAdminRegisterAdmin : UserControl
    {
        public UCAdminRegisterAdmin()
        {
            InitializeComponent();
            pnllTransparent.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            int counter = 0;
            string title, message;

            //IF TEXTBOX ARE EMPTY
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                title = "Empty Textbox";
                message = "Please fill in all fields to continue.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            //MINIMUM 5 CHARACTERS USERNAME
            if (txtUsername.Text.Length < 6 && txtPassword.Text != null)
            {
                title = "Username Error";
                message = "Username should be six characters or more.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            //MINIMUM 8 CHARACTERS PASSWORD
            if (txtPassword.Text.Length < 8 && txtPassword.Text != null)
            {
                title = "Password Error";
                message = "Password should be eight characters or more.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            //USERNAME AND PASSWORD LENGTH LIMITATIONS
            if (txtUsername.Text.Length > 50)
            {
                title = "Username Error";
                message = "Username has exceeded character limit. Please try again (Username should be less than 50 characters)";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            if (txtPassword.Text.Length > 255)
            {
                title = "Password Error";
                message = "Password has exceeded character limit. Please try again (Password should be less than 255 characters)";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            //PASSWORD AND CONFIRM PASSWORD DO NOT MATCH
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                title = "Password Error";
                message = "Password and Confirm Password do not match.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, button, icon);
            }
            else
            {
                counter++;
            }

            //IF USERNAME ALREADY EXISTS
            if (txtUsername.Text != null)
            {
                string username = txtUsername.Text;
                conn.Open();
                SqlCommand findUsername = new SqlCommand("SELECT * FROM [User] WHERE UserName = @username", conn);

                findUsername.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = findUsername.ExecuteReader();
                if (reader.HasRows)
                {
                    title = "Username Error";
                    message = "Username already exists. Please try another username.";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, title, button, icon);
                }
                else
                {
                    counter++;
                }

                conn.Close();
            }


            //REGISTERING ACCOUNT
            if (counter == 7)
            {
                try
                {
                    conn.Open();

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string hashPassword = Password.passwordHasher(password);
                    string userType = "admin";

                    SqlCommand executeReg = new SqlCommand("INSERT INTO [User] (UserName, UserPassword, UserType) VALUES (@username, @password, @userType)", conn);

                    executeReg.Parameters.AddWithValue("@username", username);
                    executeReg.Parameters.AddWithValue("@password", hashPassword);
                    executeReg.Parameters.AddWithValue("@userType", userType);

                    executeReg.ExecuteNonQuery();

                    Extra.log($"{userType} '{username}' registered an account.");
                    MessageBox.Show("Account registered! Please login to access your account.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Please Try again. " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to clear the text fields?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                txtUsername.Text = null;
                txtPassword.Text = null;
                txtConfirmPassword.Text = null;
            }
        }
    }
}
