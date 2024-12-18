﻿using System;
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
    public partial class LibraryWelcomeScreen : Form
    {
        public LibraryWelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterScreen register = new RegisterScreen();
            register.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title, message;
            title = "Go Back?";
            message = "Are you sure you want to exit the program?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
