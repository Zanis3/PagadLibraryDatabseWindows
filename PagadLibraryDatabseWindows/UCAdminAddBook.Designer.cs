namespace PagadLibraryDatabseWindows
{
    partial class UCAdminAddBook
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblBookCopies = new System.Windows.Forms.Label();
            this.txtCopyAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopyAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(204, 144);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(400, 31);
            this.txtBookName.TabIndex = 0;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Location = new System.Drawing.Point(222, 42);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(241, 55);
            this.lblAddBook.TabIndex = 1;
            this.lblAddBook.Text = "Add Book";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(92, 155);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(106, 20);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name:";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(86, 235);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(114, 20);
            this.lblBookAuthor.TabIndex = 4;
            this.lblBookAuthor.Text = "Book Author:";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.Location = new System.Drawing.Point(204, 224);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(400, 31);
            this.txtBookAuthor.TabIndex = 3;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookISBN.Location = new System.Drawing.Point(204, 299);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(400, 31);
            this.txtBookISBN.TabIndex = 5;
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookISBN.Location = new System.Drawing.Point(95, 310);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(102, 20);
            this.lblBookISBN.TabIndex = 6;
            this.lblBookISBN.Text = "Book ISBN:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(341, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddBook.Location = new System.Drawing.Point(166, 436);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(150, 50);
            this.btnAddBook.TabIndex = 18;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCopies.Location = new System.Drawing.Point(77, 379);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(122, 20);
            this.lblBookCopies.TabIndex = 21;
            this.lblBookCopies.Text = "No. of Copies:";
            // 
            // txtCopyAmount
            // 
            this.txtCopyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyAmount.Location = new System.Drawing.Point(204, 368);
            this.txtCopyAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCopyAmount.Name = "txtCopyAmount";
            this.txtCopyAmount.Size = new System.Drawing.Size(120, 31);
            this.txtCopyAmount.TabIndex = 22;
            this.txtCopyAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UCAdminAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCopyAmount);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblBookISBN);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblAddBook);
            this.Controls.Add(this.txtBookName);
            this.Name = "UCAdminAddBook";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.txtCopyAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblBookCopies;
        private System.Windows.Forms.NumericUpDown txtCopyAmount;
    }
}
