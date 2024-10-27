using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
            pnllTransparent.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        public RegisterScreen(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Go Back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LibraryWelcomeScreen welcome = new LibraryWelcomeScreen();
                welcome.Show();
                this.Hide();
            }
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
            if(txtPassword.Text.Length < 8 && txtPassword.Text != null)
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
            if(txtUsername.Text != null)
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
            if(counter == 7)
            {
                try
                {
                    conn.Open();

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string hashPassword = Password.passwordHasher(password);
                    string userType = "user";

                    SqlCommand executeReg = new SqlCommand("INSERT INTO [User] (UserName, UserPassword, UserType) VALUES (@username, @password, @userType)", conn);

                    executeReg.Parameters.AddWithValue("@username", username);
                    executeReg.Parameters.AddWithValue("@password", hashPassword);
                    executeReg.Parameters.AddWithValue("@userType", userType);

                    executeReg.ExecuteNonQuery();

                    Extra.log($"{userType} '{username}' registered an account.");
                    Extra.showSucessMessage("Account registered! Please login to access your account.");
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
}
