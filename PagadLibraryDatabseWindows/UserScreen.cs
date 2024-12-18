﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' has logged out their account.");
                Application.Exit();
            }
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutConfirm = MessageBox.Show("Are you sure you want to log out?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (logoutConfirm == DialogResult.Yes)
            {
                Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' has logged out their account.");
                Session.sessionUsername = null;
                Session.sessionUserType = null;
                LibraryWelcomeScreen logout = new LibraryWelcomeScreen();
                logout.Show();
                this.Hide();
            }
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            UCAdminViewBook viewBook = new UCAdminViewBook();
            addUserControls(viewBook);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            UCAdminUserEditAccount userSettings = new UCAdminUserEditAccount();
            addUserControls(userSettings);
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            UCUserBorrowBook borrowBook = new UCUserBorrowBook();
            addUserControls(borrowBook);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            UCUserReturnBook returnBook = new UCUserReturnBook();
            addUserControls(returnBook);
        }
    }
}
