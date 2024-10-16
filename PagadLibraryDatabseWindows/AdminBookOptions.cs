using System;
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
    public partial class AdminBookOptions : Form
    {
        public AdminBookOptions()
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            UCAdminAddBook addBook = new UCAdminAddBook();
            addUserControls(addBook);
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            UCAdminRemoveBook removeBook = new UCAdminRemoveBook();
            addUserControls(removeBook);
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            UCAdminEditBook editBook = new UCAdminEditBook();
            addUserControls(editBook);
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            UCAdminViewBook viewBook = new UCAdminViewBook();
            addUserControls(viewBook);
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
    }
}
