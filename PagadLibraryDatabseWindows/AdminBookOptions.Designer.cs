namespace PagadLibraryDatabseWindows
{
    partial class AdminBookOptions
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Sienna;
            this.pnlMenu.Controls.Add(this.btnBack);
            this.pnlMenu.Controls.Add(this.btnViewBook);
            this.pnlMenu.Controls.Add(this.btnEditBook);
            this.pnlMenu.Controls.Add(this.btnRemoveBook);
            this.pnlMenu.Controls.Add(this.btnAddBook);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 564);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Sienna;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBook.Location = new System.Drawing.Point(-7, 61);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(307, 80);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.Sienna;
            this.btnRemoveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveBook.Location = new System.Drawing.Point(-3, 148);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(307, 80);
            this.btnRemoveBook.TabIndex = 1;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.BackColor = System.Drawing.Color.Sienna;
            this.btnViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewBook.Location = new System.Drawing.Point(-1, 322);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(307, 80);
            this.btnViewBook.TabIndex = 3;
            this.btnViewBook.Text = "View All Books";
            this.btnViewBook.UseVisualStyleBackColor = false;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.Sienna;
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditBook.Location = new System.Drawing.Point(-5, 235);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(307, 80);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(-3, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(307, 80);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(299, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(710, 560);
            this.pnlContainer.TabIndex = 1;
            // 
            // AdminBookOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminBookOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBookOptions";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Panel pnlContainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}