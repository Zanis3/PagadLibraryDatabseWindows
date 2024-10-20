namespace PagadLibraryDatabseWindows
{
    partial class UserScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnEditAccount);
            this.pnlMenu.Controls.Add(this.btnReturnBook);
            this.pnlMenu.Controls.Add(this.btnBorrowBook);
            this.pnlMenu.Controls.Add(this.btnViewBook);
            this.pnlMenu.Location = new System.Drawing.Point(0, -2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 564);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(-3, 461);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(307, 80);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditAccount.Location = new System.Drawing.Point(-1, 322);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(307, 80);
            this.btnEditAccount.TabIndex = 3;
            this.btnEditAccount.Text = "Edit User Account";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturnBook.Location = new System.Drawing.Point(-5, 235);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(307, 80);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrowBook.Location = new System.Drawing.Point(-3, 148);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(307, 80);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.BackColor = System.Drawing.Color.DarkCyan;
            this.btnViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewBook.Location = new System.Drawing.Point(-7, 61);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(307, 80);
            this.btnViewBook.TabIndex = 0;
            this.btnViewBook.Text = "View All Books";
            this.btnViewBook.UseVisualStyleBackColor = false;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(300, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(710, 560);
            this.pnlContainer.TabIndex = 3;
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Screen";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Panel pnlContainer;
    }
}