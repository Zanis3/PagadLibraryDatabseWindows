namespace PagadLibraryDatabseWindows
{
    partial class UCUserBorrowBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.tblViewBooks = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblBorrowBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(270, 487);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tblViewBooks
            // 
            this.tblViewBooks.AllowUserToAddRows = false;
            this.tblViewBooks.AllowUserToDeleteRows = false;
            this.tblViewBooks.AllowUserToResizeColumns = false;
            this.tblViewBooks.AllowUserToResizeRows = false;
            this.tblViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewBooks.Location = new System.Drawing.Point(70, 231);
            this.tblViewBooks.Name = "tblViewBooks";
            this.tblViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblViewBooks.Size = new System.Drawing.Size(559, 250);
            this.tblViewBooks.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(479, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchOptions
            // 
            this.cboSearchOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cboSearchOptions.FormattingEnabled = true;
            this.cboSearchOptions.Items.AddRange(new object[] {
            "BookID",
            "BookName",
            "BookAuthor"});
            this.cboSearchOptions.Location = new System.Drawing.Point(300, 123);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.Size = new System.Drawing.Size(150, 33);
            this.cboSearchOptions.TabIndex = 22;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(70, 123);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(200, 31);
            this.txtSearchBar.TabIndex = 21;
            // 
            // lblBorrowBook
            // 
            this.lblBorrowBook.AutoSize = true;
            this.lblBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowBook.Location = new System.Drawing.Point(181, 44);
            this.lblBorrowBook.Name = "lblBorrowBook";
            this.lblBorrowBook.Size = new System.Drawing.Size(311, 55);
            this.lblBorrowBook.TabIndex = 20;
            this.lblBorrowBook.Text = "Borrow Book";
            // 
            // UCUserBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tblViewBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchOptions);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblBorrowBook);
            this.Name = "UCUserBorrowBook";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView tblViewBooks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchOptions;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblBorrowBook;
    }
}
