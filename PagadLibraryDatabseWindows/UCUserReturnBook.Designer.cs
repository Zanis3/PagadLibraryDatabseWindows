namespace PagadLibraryDatabseWindows
{
    partial class UCUserReturnBook
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
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.tblViewBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(196, 68);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(303, 55);
            this.lblReturnBook.TabIndex = 4;
            this.lblReturnBook.Text = "Return Book";
            // 
            // tblViewBooks
            // 
            this.tblViewBooks.AllowUserToAddRows = false;
            this.tblViewBooks.AllowUserToDeleteRows = false;
            this.tblViewBooks.AllowUserToResizeColumns = false;
            this.tblViewBooks.AllowUserToResizeRows = false;
            this.tblViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewBooks.Location = new System.Drawing.Point(70, 214);
            this.tblViewBooks.Name = "tblViewBooks";
            this.tblViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblViewBooks.Size = new System.Drawing.Size(559, 250);
            this.tblViewBooks.TabIndex = 24;
            // 
            // UCUserReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblViewBooks);
            this.Controls.Add(this.lblReturnBook);
            this.Name = "UCUserReturnBook";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.DataGridView tblViewBooks;
    }
}
