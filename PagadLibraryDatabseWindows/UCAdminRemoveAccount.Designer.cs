namespace PagadLibraryDatabseWindows
{
    partial class UCAdminRemoveAccount
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
            this.tblViewAccounts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblRemoveAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(277, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tblViewAccounts
            // 
            this.tblViewAccounts.AllowUserToAddRows = false;
            this.tblViewAccounts.AllowUserToDeleteRows = false;
            this.tblViewAccounts.AllowUserToResizeColumns = false;
            this.tblViewAccounts.AllowUserToResizeRows = false;
            this.tblViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewAccounts.Location = new System.Drawing.Point(77, 227);
            this.tblViewAccounts.Name = "tblViewAccounts";
            this.tblViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblViewAccounts.Size = new System.Drawing.Size(559, 250);
            this.tblViewAccounts.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(486, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 28;
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
            "UserID",
            "UserName",
            "UserType"});
            this.cboSearchOptions.Location = new System.Drawing.Point(307, 135);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.Size = new System.Drawing.Size(150, 33);
            this.cboSearchOptions.TabIndex = 27;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(77, 135);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(200, 31);
            this.txtSearchBar.TabIndex = 26;
            // 
            // lblRemoveAccount
            // 
            this.lblRemoveAccount.AutoSize = true;
            this.lblRemoveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAccount.Location = new System.Drawing.Point(159, 52);
            this.lblRemoveAccount.Name = "lblRemoveAccount";
            this.lblRemoveAccount.Size = new System.Drawing.Size(405, 55);
            this.lblRemoveAccount.TabIndex = 25;
            this.lblRemoveAccount.Text = "Remove Account";
            // 
            // UCAdminRemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tblViewAccounts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchOptions);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblRemoveAccount);
            this.Name = "UCAdminRemoveAccount";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView tblViewAccounts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchOptions;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblRemoveAccount;
    }
}
