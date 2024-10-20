namespace PagadLibraryDatabseWindows
{
    partial class UCAdminViewBook
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
            this.components = new System.ComponentModel.Container();
            this.lblViewBooks = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.cboSearchOptions = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblViewBooks = new System.Windows.Forms.DataGridView();
            this.pagadLibraryApplicationDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagadLibraryApplicationDatabaseDataSet = new PagadLibraryDatabseWindows.PagadLibraryApplicationDatabaseDataSet();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadLibraryApplicationDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadLibraryApplicationDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewBooks
            // 
            this.lblViewBooks.AutoSize = true;
            this.lblViewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBooks.Location = new System.Drawing.Point(206, 58);
            this.lblViewBooks.Name = "lblViewBooks";
            this.lblViewBooks.Size = new System.Drawing.Size(285, 55);
            this.lblViewBooks.TabIndex = 3;
            this.lblViewBooks.Text = "View Books";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(68, 137);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(200, 31);
            this.txtSearchBar.TabIndex = 4;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
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
            this.cboSearchOptions.Location = new System.Drawing.Point(298, 137);
            this.cboSearchOptions.Name = "cboSearchOptions";
            this.cboSearchOptions.Size = new System.Drawing.Size(150, 33);
            this.cboSearchOptions.TabIndex = 5;
            this.cboSearchOptions.SelectedIndexChanged += new System.EventHandler(this.cboSearchOptions_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(477, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tblViewBooks
            // 
            this.tblViewBooks.AllowUserToAddRows = false;
            this.tblViewBooks.AllowUserToDeleteRows = false;
            this.tblViewBooks.AllowUserToResizeColumns = false;
            this.tblViewBooks.AllowUserToResizeRows = false;
            this.tblViewBooks.AutoGenerateColumns = false;
            this.tblViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewBooks.DataSource = this.pagadLibraryApplicationDatabaseDataSetBindingSource;
            this.tblViewBooks.Location = new System.Drawing.Point(68, 245);
            this.tblViewBooks.Name = "tblViewBooks";
            this.tblViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblViewBooks.Size = new System.Drawing.Size(559, 250);
            this.tblViewBooks.TabIndex = 18;
            this.tblViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblViewBooks_CellContentClick);
            // 
            // pagadLibraryApplicationDatabaseDataSetBindingSource
            // 
            this.pagadLibraryApplicationDatabaseDataSetBindingSource.DataSource = this.pagadLibraryApplicationDatabaseDataSet;
            this.pagadLibraryApplicationDatabaseDataSetBindingSource.Position = 0;
            // 
            // pagadLibraryApplicationDatabaseDataSet
            // 
            this.pagadLibraryApplicationDatabaseDataSet.DataSetName = "PagadLibraryApplicationDatabaseDataSet";
            this.pagadLibraryApplicationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(268, 501);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UCAdminViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tblViewBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchOptions);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblViewBooks);
            this.Name = "UCAdminViewBook";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadLibraryApplicationDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagadLibraryApplicationDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewBooks;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.ComboBox cboSearchOptions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView tblViewBooks;
        private System.Windows.Forms.BindingSource pagadLibraryApplicationDatabaseDataSetBindingSource;
        private PagadLibraryApplicationDatabaseDataSet pagadLibraryApplicationDatabaseDataSet;
        private System.Windows.Forms.Button btnClear;
    }
}
