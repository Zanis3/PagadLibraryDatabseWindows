namespace PagadLibraryDatabseWindows
{
    partial class UCAdminRemoveBook
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
            this.lblRemoveBook = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tblViewBooks = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.AutoSize = true;
            this.lblRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBook.Location = new System.Drawing.Point(176, 60);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Size = new System.Drawing.Size(338, 55);
            this.lblRemoveBook.TabIndex = 3;
            this.lblRemoveBook.Text = "Remove Book";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(270, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 24;
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
            this.tblViewBooks.Location = new System.Drawing.Point(70, 235);
            this.tblViewBooks.Name = "tblViewBooks";
            this.tblViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblViewBooks.Size = new System.Drawing.Size(559, 250);
            this.tblViewBooks.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(479, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 22;
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
            this.cboSearchOptions.Location = new System.Drawing.Point(300, 143);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.Size = new System.Drawing.Size(150, 33);
            this.cboSearchOptions.TabIndex = 21;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(70, 143);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(200, 31);
            this.txtSearchBar.TabIndex = 20;
            // 
            // UCAdminRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tblViewBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchOptions);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblRemoveBook);
            this.Name = "UCAdminRemoveBook";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveBook;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView tblViewBooks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchOptions;
        private System.Windows.Forms.TextBox txtSearchBar;
    }
}
