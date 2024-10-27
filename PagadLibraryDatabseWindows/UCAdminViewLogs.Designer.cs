namespace PagadLibraryDatabseWindows
{
    partial class UCAdminViewLogs
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
            this.lblViewLog = new System.Windows.Forms.Label();
            this.tblViewLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewLog
            // 
            this.lblViewLog.AutoSize = true;
            this.lblViewLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewLog.Location = new System.Drawing.Point(217, 55);
            this.lblViewLog.Name = "lblViewLog";
            this.lblViewLog.Size = new System.Drawing.Size(255, 55);
            this.lblViewLog.TabIndex = 3;
            this.lblViewLog.Text = "View Logs";
            // 
            // tblViewLogs
            // 
            this.tblViewLogs.AllowUserToAddRows = false;
            this.tblViewLogs.AllowUserToDeleteRows = false;
            this.tblViewLogs.AllowUserToResizeRows = false;
            this.tblViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewLogs.Location = new System.Drawing.Point(77, 153);
            this.tblViewLogs.Name = "tblViewLogs";
            this.tblViewLogs.Size = new System.Drawing.Size(559, 333);
            this.tblViewLogs.TabIndex = 24;
            // 
            // UCAdminViewLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblViewLogs);
            this.Controls.Add(this.lblViewLog);
            this.Name = "UCAdminViewLogs";
            this.Size = new System.Drawing.Size(710, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewLog;
        private System.Windows.Forms.DataGridView tblViewLogs;
    }
}
