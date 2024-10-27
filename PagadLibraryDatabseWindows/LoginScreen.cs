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
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Go Back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                            Extra.showWarningMessage("Wrong Username or Password. Please Try Again.");
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
                    Extra.showException(ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Extra.showWarningMessage("Please fill in all fields to continue.");
            }
        }
    }
}
