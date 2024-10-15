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
        }

        public RegisterScreen(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string title, message;
            title = "Go Back?";
            message = "Are you sure you want to go back?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                LibraryWelcomeScreen welcome = new LibraryWelcomeScreen();
                welcome.Show();
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\PagadLibraryDatabseWindows\PagadLibraryDatabseWindows\PagadLibraryApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");
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
            if(txtPassword.Text.Length < 8 && txtPassword.Text != null)
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
            if(txtUsername.Text != null)
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

                    MessageBox.Show("Account registered! Please login to access your account.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong. Please Try again. " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
