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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            pnllTransparent.BackColor = Color.FromArgb(128, 0, 0, 0);
            lblWelcomeText.Text = $"Good day, {Session.sessionUsername}!";
        }

        private void btnAdminBookOptions_Click(object sender, EventArgs e)
        {
            AdminBookOptions book = new AdminBookOptions();
            book.Show();
            this.Hide();
        }

        private void btnAdminAccountOptions_Click(object sender, EventArgs e)
        {
            AdminAccountMngmOptions acc = new AdminAccountMngmOptions();
            acc.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutConfirm = MessageBox.Show("Are you sure you want to log out?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(logoutConfirm == DialogResult.Yes)
            {
                Session.sessionUsername = null;
                Session.sessionUserType = null;
                LibraryWelcomeScreen logout = new LibraryWelcomeScreen();
                logout.Show();
                this.Close();
            }
        }
    }
}
