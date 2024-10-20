using Microsoft.Win32;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            pnllTransparent.BackColor = Color.FromArgb(128, 0, 0, 0);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            //IF USERNAME IS NOT EMPTY
            if (txtUsername.Text != null)
            {
                try
                {
                    conn.Open();
                    SqlCommand findUsername = new SqlCommand("SELECT * FROM [User] WHERE UserName = @username", conn);

                    findUsername.Parameters.AddWithValue("@username", txtUsername.Text);
                    SqlDataReader reader = findUsername.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string hashPass = reader["UserPassword"].ToString();
                        string password = txtPassword.Text;
                        string userType = reader["UserType"].ToString();
                        int userID = Convert.ToInt16(reader["UserID"]);
                        bool passwordVerifier = Password.hashVerifier(hashPass, password);

                        //PAG MALI PASSWORD
                        if(passwordVerifier == false)
                        {
                            MessageBox.Show($"Wrong Username or Password. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Session.sessionUsername = txtUsername.Text;
                            Session.sessionUserType = userType;
                            Session.sessionUserID = userID;

                            Extra.log($"{userType} '{txtUsername.Text}' logged into their account.");

                            if(userType == "user")
                            {
                                UserScreen user = new UserScreen();
                                user.Show();
                                this.Close();

                            }
                            else if(userType == "admin")
                            {
                                AdminScreen admin = new AdminScreen();
                                admin.Show();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        //IF USERNAME IS NOT FOUND
                        DialogResult result = MessageBox.Show($"Username not found. Proceed with registration?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if(result == DialogResult.Yes)
                        {
                            RegisterScreen register = new RegisterScreen(txtUsername.Text);
                            register.Show();
                            this.Close();
                        }
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
            else
            {
                MessageBox.Show("There are empty fields. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
