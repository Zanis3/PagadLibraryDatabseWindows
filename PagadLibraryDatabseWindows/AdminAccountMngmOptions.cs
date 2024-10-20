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
    public partial class AdminAccountMngmOptions : Form
    {
        public AdminAccountMngmOptions()
        {
            InitializeComponent();
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            UCAdminUserEditAccount userSettings = new UCAdminUserEditAccount();
            addUserControls(userSettings);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Go Back?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AdminScreen adminScreen = new AdminScreen();
                adminScreen.Show();
                this.Close();
            }
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            UCAdminRegisterAdmin registerAdmin = new UCAdminRegisterAdmin();
            addUserControls(registerAdmin);
        }
    }
}
