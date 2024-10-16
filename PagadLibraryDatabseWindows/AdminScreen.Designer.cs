namespace PagadLibraryDatabseWindows
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.pnlAdminOptions = new System.Windows.Forms.Panel();
            this.btnAdminAccountOptions = new System.Windows.Forms.Button();
            this.btnAdminBookOptions = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnllTransparent = new System.Windows.Forms.Panel();
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.pnlAdminOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdminOptions
            // 
            this.pnlAdminOptions.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAdminOptions.Controls.Add(this.lblWelcomeText);
            this.pnlAdminOptions.Controls.Add(this.btnLogout);
            this.pnlAdminOptions.Controls.Add(this.btnAdminAccountOptions);
            this.pnlAdminOptions.Controls.Add(this.btnAdminBookOptions);
            this.pnlAdminOptions.Location = new System.Drawing.Point(98, 53);
            this.pnlAdminOptions.Name = "pnlAdminOptions";
            this.pnlAdminOptions.Size = new System.Drawing.Size(779, 455);
            this.pnlAdminOptions.TabIndex = 0;
            // 
            // btnAdminAccountOptions
            // 
            this.btnAdminAccountOptions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdminAccountOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminAccountOptions.BackgroundImage")));
            this.btnAdminAccountOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminAccountOptions.Location = new System.Drawing.Point(462, 169);
            this.btnAdminAccountOptions.Name = "btnAdminAccountOptions";
            this.btnAdminAccountOptions.Size = new System.Drawing.Size(200, 200);
            this.btnAdminAccountOptions.TabIndex = 1;
            this.btnAdminAccountOptions.UseVisualStyleBackColor = false;
            this.btnAdminAccountOptions.Click += new System.EventHandler(this.btnAdminAccountOptions_Click);
            // 
            // btnAdminBookOptions
            // 
            this.btnAdminBookOptions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdminBookOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminBookOptions.BackgroundImage")));
            this.btnAdminBookOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminBookOptions.Location = new System.Drawing.Point(103, 169);
            this.btnAdminBookOptions.Name = "btnAdminBookOptions";
            this.btnAdminBookOptions.Size = new System.Drawing.Size(200, 200);
            this.btnAdminBookOptions.TabIndex = 0;
            this.btnAdminBookOptions.UseVisualStyleBackColor = false;
            this.btnAdminBookOptions.Click += new System.EventHandler(this.btnAdminBookOptions_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(613, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = ">> LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnllTransparent
            // 
            this.pnllTransparent.Location = new System.Drawing.Point(-7, -3);
            this.pnllTransparent.Name = "pnllTransparent";
            this.pnllTransparent.Size = new System.Drawing.Size(1022, 567);
            this.pnllTransparent.TabIndex = 3;
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(26, 31);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(255, 55);
            this.lblWelcomeText.TabIndex = 10;
            this.lblWelcomeText.Text = "Good day,";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PagadLibraryDatabseWindows.Properties.Resources.loginreegister;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlAdminOptions);
            this.Controls.Add(this.pnllTransparent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen";
            this.pnlAdminOptions.ResumeLayout(false);
            this.pnlAdminOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminOptions;
        private System.Windows.Forms.Button btnAdminAccountOptions;
        private System.Windows.Forms.Button btnAdminBookOptions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnllTransparent;
        private System.Windows.Forms.Label lblWelcomeText;
    }
}