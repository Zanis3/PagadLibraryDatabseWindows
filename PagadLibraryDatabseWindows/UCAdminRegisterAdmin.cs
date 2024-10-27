﻿using System;
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

            //IF TEXTBOX ARE EMPTY
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                Extra.showWarningMessage("Please fill in all fields to continue.");
            }
            else
            {
                counter++;
            }

            //MINIMUM 5 CHARACTERS USERNAME
            if (txtUsername.Text.Length < 6 && txtPassword.Text != null)
            {
                Extra.showWarningMessage("Username should be six characters or more.");
            }
            else
            {
                counter++;
            }

            //MINIMUM 8 CHARACTERS PASSWORD
            if (txtPassword.Text.Length < 8 && txtPassword.Text != null)
            {
                Extra.showWarningMessage("Password should be eight characters or more.");
            }
            else
            {
                counter++;
            }

            //USERNAME AND PASSWORD LENGTH LIMITATIONS
            if (txtUsername.Text.Length > 50)
            {
                Extra.showWarningMessage("Username has exceeded character limit. Please try again (Username should be less than 50 characters)");
            }
            else
            {
                counter++;
            }

            if (txtPassword.Text.Length > 255)
            {
                Extra.showWarningMessage("Password has exceeded character limit. Please try again (Password should be less than 255 characters)");
            }
            else
            {
                counter++;
            }

            //PASSWORD AND CONFIRM PASSWORD DO NOT MATCH
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                Extra.showWarningMessage("Password and Confirm Password do not match.");
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
                    Extra.showWarningMessage("Username already exists. Please try another username.");
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
                    Extra.showSucessMessage("Account registered! Please login to access your account.");
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
