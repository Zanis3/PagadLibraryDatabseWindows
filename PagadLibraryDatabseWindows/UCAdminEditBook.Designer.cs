namespace PagadLibraryDatabseWindows
{
    partial class UCAdminEditBook
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
            this.lblEditBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditBook
            // 
            this.lblEditBook.AutoSize = true;
            this.lblEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBook.Location = new System.Drawing.Point(235, 66);
            this.lblEditBook.Name = "lblEditBook";
            this.lblEditBook.Size = new System.Drawing.Size(238, 55);
            this.lblEditBook.TabIndex = 2;
            this.lblEditBook.Text = "Edit Book";
            // 
            // UCAdminEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEditBook);
            this.Name = "UCAdminEditBook";
            this.Size = new System.Drawing.Size(710, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditBook;
    }
}
