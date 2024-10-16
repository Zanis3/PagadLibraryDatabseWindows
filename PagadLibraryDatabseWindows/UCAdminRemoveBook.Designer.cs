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
            // UCAdminRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemoveBook);
            this.Name = "UCAdminRemoveBook";
            this.Size = new System.Drawing.Size(710, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveBook;
    }
}
