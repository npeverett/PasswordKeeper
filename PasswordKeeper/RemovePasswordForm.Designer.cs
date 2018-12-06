namespace PasswordKeeper
{
    partial class RemovePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovePasswordForm));
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.logoLabel = new System.Windows.Forms.Label();
            this.panelLEFT = new System.Windows.Forms.Panel();
            this.homepageButton = new System.Windows.Forms.Button();
            this.cpyrtLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.removePassButton = new System.Windows.Forms.Button();
            this.addPassButton = new System.Windows.Forms.Button();
            this.checkStrengthButton = new System.Windows.Forms.Button();
            this.currentPasswords = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panelCurrPass = new System.Windows.Forms.Panel();
            this.numPSW = new System.Windows.Forms.Label();
            this.chromeButtonD = new System.Windows.Forms.Button();
            this.gmailButtonD = new System.Windows.Forms.Button();
            this.yahooButtonD = new System.Windows.Forms.Button();
            this.googleDriveButtonD = new System.Windows.Forms.Button();
            this.outlookButtonD = new System.Windows.Forms.Button();
            this.facebookButtonD = new System.Windows.Forms.Button();
            this.instagramButtonD = new System.Windows.Forms.Button();
            this.snapchatButtonD = new System.Windows.Forms.Button();
            this.twitchButtonD = new System.Windows.Forms.Button();
            this.otherButtonD = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.passwordListBox = new System.Windows.Forms.ListBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.panelLEFT.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoLabel.Location = new System.Drawing.Point(33, 4);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(136, 96);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "SP";
            // 
            // panelLEFT
            // 
            this.panelLEFT.Controls.Add(this.homepageButton);
            this.panelLEFT.Controls.Add(this.cpyrtLabel);
            this.panelLEFT.Controls.Add(this.companyLabel);
            this.panelLEFT.Controls.Add(this.removePassButton);
            this.panelLEFT.Controls.Add(this.addPassButton);
            this.panelLEFT.Controls.Add(this.checkStrengthButton);
            this.panelLEFT.Controls.Add(this.currentPasswords);
            this.panelLEFT.Controls.Add(this.logoPanel);
            this.panelLEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLEFT.Location = new System.Drawing.Point(0, 0);
            this.panelLEFT.Name = "panelLEFT";
            this.panelLEFT.Size = new System.Drawing.Size(200, 719);
            this.panelLEFT.TabIndex = 1;
            // 
            // homepageButton
            // 
            this.homepageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.Image = ((System.Drawing.Image)(resources.GetObject("homepageButton.Image")));
            this.homepageButton.Location = new System.Drawing.Point(49, 592);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(93, 91);
            this.homepageButton.TabIndex = 7;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // cpyrtLabel
            // 
            this.cpyrtLabel.AutoSize = true;
            this.cpyrtLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpyrtLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cpyrtLabel.Location = new System.Drawing.Point(100, 704);
            this.cpyrtLabel.Name = "cpyrtLabel";
            this.cpyrtLabel.Size = new System.Drawing.Size(87, 15);
            this.cpyrtLabel.TabIndex = 6;
            this.cpyrtLabel.Text = "Copyright 2018";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.companyLabel.Location = new System.Drawing.Point(3, 704);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(91, 15);
            this.companyLabel.TabIndex = 5;
            this.companyLabel.Text = "Smart Password";
            // 
            // removePassButton
            // 
            this.removePassButton.BackColor = System.Drawing.Color.Transparent;
            this.removePassButton.FlatAppearance.BorderSize = 0;
            this.removePassButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removePassButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.removePassButton.Image = ((System.Drawing.Image)(resources.GetObject("removePassButton.Image")));
            this.removePassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePassButton.Location = new System.Drawing.Point(0, 461);
            this.removePassButton.Name = "removePassButton";
            this.removePassButton.Size = new System.Drawing.Size(200, 106);
            this.removePassButton.TabIndex = 4;
            this.removePassButton.Text = " Remove Password";
            this.removePassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removePassButton.UseVisualStyleBackColor = false;
            // 
            // addPassButton
            // 
            this.addPassButton.BackColor = System.Drawing.Color.Transparent;
            this.addPassButton.FlatAppearance.BorderSize = 0;
            this.addPassButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPassButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addPassButton.Image = ((System.Drawing.Image)(resources.GetObject("addPassButton.Image")));
            this.addPassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPassButton.Location = new System.Drawing.Point(0, 349);
            this.addPassButton.Name = "addPassButton";
            this.addPassButton.Size = new System.Drawing.Size(200, 106);
            this.addPassButton.TabIndex = 3;
            this.addPassButton.Text = "       Add New Password";
            this.addPassButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPassButton.UseVisualStyleBackColor = false;
            this.addPassButton.Click += new System.EventHandler(this.addPassButton_Click);
            // 
            // checkStrengthButton
            // 
            this.checkStrengthButton.BackColor = System.Drawing.Color.Transparent;
            this.checkStrengthButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkStrengthButton.FlatAppearance.BorderSize = 0;
            this.checkStrengthButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkStrengthButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkStrengthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStrengthButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkStrengthButton.ForeColor = System.Drawing.Color.Transparent;
            this.checkStrengthButton.Image = ((System.Drawing.Image)(resources.GetObject("checkStrengthButton.Image")));
            this.checkStrengthButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkStrengthButton.Location = new System.Drawing.Point(0, 237);
            this.checkStrengthButton.Name = "checkStrengthButton";
            this.checkStrengthButton.Size = new System.Drawing.Size(200, 106);
            this.checkStrengthButton.TabIndex = 2;
            this.checkStrengthButton.Text = "Check Password Strength";
            this.checkStrengthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkStrengthButton.UseVisualStyleBackColor = false;
            // 
            // currentPasswords
            // 
            this.currentPasswords.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswords.FlatAppearance.BorderSize = 0;
            this.currentPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPasswords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswords.ForeColor = System.Drawing.Color.White;
            this.currentPasswords.Image = ((System.Drawing.Image)(resources.GetObject("currentPasswords.Image")));
            this.currentPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentPasswords.Location = new System.Drawing.Point(0, 125);
            this.currentPasswords.Name = "currentPasswords";
            this.currentPasswords.Size = new System.Drawing.Size(200, 106);
            this.currentPasswords.TabIndex = 1;
            this.currentPasswords.Text = "Current Passwords";
            this.currentPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.currentPasswords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.currentPasswords.UseVisualStyleBackColor = false;
            this.currentPasswords.Click += new System.EventHandler(this.currentPasswords_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // panelCurrPass
            // 
            this.panelCurrPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelCurrPass.Location = new System.Drawing.Point(199, 125);
            this.panelCurrPass.Name = "panelCurrPass";
            this.panelCurrPass.Size = new System.Drawing.Size(7, 106);
            this.panelCurrPass.TabIndex = 2;
            // 
            // numPSW
            // 
            this.numPSW.AutoSize = true;
            this.numPSW.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.numPSW.Location = new System.Drawing.Point(650, 199);
            this.numPSW.Name = "numPSW";
            this.numPSW.Size = new System.Drawing.Size(0, 32);
            this.numPSW.TabIndex = 7;
            // 
            // chromeButtonD
            // 
            this.chromeButtonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chromeButtonD.FlatAppearance.BorderSize = 0;
            this.chromeButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chromeButtonD.Image = ((System.Drawing.Image)(resources.GetObject("chromeButtonD.Image")));
            this.chromeButtonD.Location = new System.Drawing.Point(284, 100);
            this.chromeButtonD.Name = "chromeButtonD";
            this.chromeButtonD.Size = new System.Drawing.Size(54, 51);
            this.chromeButtonD.TabIndex = 8;
            this.chromeButtonD.UseVisualStyleBackColor = true;
            // 
            // gmailButtonD
            // 
            this.gmailButtonD.FlatAppearance.BorderSize = 0;
            this.gmailButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gmailButtonD.Image = ((System.Drawing.Image)(resources.GetObject("gmailButtonD.Image")));
            this.gmailButtonD.Location = new System.Drawing.Point(344, 100);
            this.gmailButtonD.Name = "gmailButtonD";
            this.gmailButtonD.Size = new System.Drawing.Size(62, 51);
            this.gmailButtonD.TabIndex = 9;
            this.gmailButtonD.UseVisualStyleBackColor = true;
            // 
            // yahooButtonD
            // 
            this.yahooButtonD.FlatAppearance.BorderSize = 0;
            this.yahooButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahooButtonD.Image = ((System.Drawing.Image)(resources.GetObject("yahooButtonD.Image")));
            this.yahooButtonD.Location = new System.Drawing.Point(412, 100);
            this.yahooButtonD.Name = "yahooButtonD";
            this.yahooButtonD.Size = new System.Drawing.Size(52, 51);
            this.yahooButtonD.TabIndex = 10;
            this.yahooButtonD.UseVisualStyleBackColor = true;
            // 
            // googleDriveButtonD
            // 
            this.googleDriveButtonD.FlatAppearance.BorderSize = 0;
            this.googleDriveButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.googleDriveButtonD.Image = ((System.Drawing.Image)(resources.GetObject("googleDriveButtonD.Image")));
            this.googleDriveButtonD.Location = new System.Drawing.Point(470, 100);
            this.googleDriveButtonD.Name = "googleDriveButtonD";
            this.googleDriveButtonD.Size = new System.Drawing.Size(64, 51);
            this.googleDriveButtonD.TabIndex = 11;
            this.googleDriveButtonD.UseVisualStyleBackColor = true;
            // 
            // outlookButtonD
            // 
            this.outlookButtonD.FlatAppearance.BorderSize = 0;
            this.outlookButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outlookButtonD.Image = ((System.Drawing.Image)(resources.GetObject("outlookButtonD.Image")));
            this.outlookButtonD.Location = new System.Drawing.Point(540, 100);
            this.outlookButtonD.Name = "outlookButtonD";
            this.outlookButtonD.Size = new System.Drawing.Size(57, 51);
            this.outlookButtonD.TabIndex = 12;
            this.outlookButtonD.UseVisualStyleBackColor = true;
            // 
            // facebookButtonD
            // 
            this.facebookButtonD.FlatAppearance.BorderSize = 0;
            this.facebookButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebookButtonD.Image = ((System.Drawing.Image)(resources.GetObject("facebookButtonD.Image")));
            this.facebookButtonD.Location = new System.Drawing.Point(603, 100);
            this.facebookButtonD.Name = "facebookButtonD";
            this.facebookButtonD.Size = new System.Drawing.Size(61, 51);
            this.facebookButtonD.TabIndex = 13;
            this.facebookButtonD.UseVisualStyleBackColor = true;
            // 
            // instagramButtonD
            // 
            this.instagramButtonD.FlatAppearance.BorderSize = 0;
            this.instagramButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instagramButtonD.Image = ((System.Drawing.Image)(resources.GetObject("instagramButtonD.Image")));
            this.instagramButtonD.Location = new System.Drawing.Point(670, 100);
            this.instagramButtonD.Name = "instagramButtonD";
            this.instagramButtonD.Size = new System.Drawing.Size(55, 51);
            this.instagramButtonD.TabIndex = 14;
            this.instagramButtonD.UseVisualStyleBackColor = true;
            // 
            // snapchatButtonD
            // 
            this.snapchatButtonD.FlatAppearance.BorderSize = 0;
            this.snapchatButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapchatButtonD.Image = ((System.Drawing.Image)(resources.GetObject("snapchatButtonD.Image")));
            this.snapchatButtonD.Location = new System.Drawing.Point(731, 100);
            this.snapchatButtonD.Name = "snapchatButtonD";
            this.snapchatButtonD.Size = new System.Drawing.Size(57, 51);
            this.snapchatButtonD.TabIndex = 15;
            this.snapchatButtonD.UseVisualStyleBackColor = true;
            // 
            // twitchButtonD
            // 
            this.twitchButtonD.FlatAppearance.BorderSize = 0;
            this.twitchButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitchButtonD.Image = ((System.Drawing.Image)(resources.GetObject("twitchButtonD.Image")));
            this.twitchButtonD.Location = new System.Drawing.Point(806, 100);
            this.twitchButtonD.Name = "twitchButtonD";
            this.twitchButtonD.Size = new System.Drawing.Size(58, 51);
            this.twitchButtonD.TabIndex = 16;
            this.twitchButtonD.UseVisualStyleBackColor = true;
            // 
            // otherButtonD
            // 
            this.otherButtonD.FlatAppearance.BorderSize = 0;
            this.otherButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherButtonD.Image = ((System.Drawing.Image)(resources.GetObject("otherButtonD.Image")));
            this.otherButtonD.Location = new System.Drawing.Point(1005, 100);
            this.otherButtonD.Name = "otherButtonD";
            this.otherButtonD.Size = new System.Drawing.Size(58, 51);
            this.otherButtonD.TabIndex = 17;
            this.otherButtonD.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.deleteButton.Location = new System.Drawing.Point(577, 608);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(211, 59);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete Password";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // passwordListBox
            // 
            this.passwordListBox.FormattingEnabled = true;
            this.passwordListBox.Location = new System.Drawing.Point(284, 199);
            this.passwordListBox.Name = "passwordListBox";
            this.passwordListBox.Size = new System.Drawing.Size(779, 394);
            this.passwordListBox.TabIndex = 19;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.DimGray;
            this.warningLabel.Location = new System.Drawing.Point(580, 681);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(208, 15);
            this.warningLabel.TabIndex = 20;
            this.warningLabel.Text = "Warning! This action can\'t be undone.\r\n";
            // 
            // RemovePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 719);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.passwordListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.otherButtonD);
            this.Controls.Add(this.twitchButtonD);
            this.Controls.Add(this.snapchatButtonD);
            this.Controls.Add(this.instagramButtonD);
            this.Controls.Add(this.facebookButtonD);
            this.Controls.Add(this.outlookButtonD);
            this.Controls.Add(this.googleDriveButtonD);
            this.Controls.Add(this.yahooButtonD);
            this.Controls.Add(this.gmailButtonD);
            this.Controls.Add(this.chromeButtonD);
            this.Controls.Add(this.numPSW);
            this.Controls.Add(this.panelCurrPass);
            this.Controls.Add(this.panelLEFT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1188, 752);
            this.MinimumSize = new System.Drawing.Size(1188, 752);
            this.Name = "RemovePasswordForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1188, 752);
            this.Text = "Smarter Password";
            this.ThemeName = "FluentDark";
            this.panelLEFT.ResumeLayout(false);
            this.panelLEFT.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel panelLEFT;
        private System.Windows.Forms.Button currentPasswords;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button removePassButton;
        private System.Windows.Forms.Button addPassButton;
        private System.Windows.Forms.Button checkStrengthButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label cpyrtLabel;
        private System.Windows.Forms.Panel panelCurrPass;
        private System.Windows.Forms.Label numPSW;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button chromeButtonD;
        private System.Windows.Forms.Button gmailButtonD;
        private System.Windows.Forms.Button yahooButtonD;
        private System.Windows.Forms.Button googleDriveButtonD;
        private System.Windows.Forms.Button outlookButtonD;
        private System.Windows.Forms.Button facebookButtonD;
        private System.Windows.Forms.Button instagramButtonD;
        private System.Windows.Forms.Button snapchatButtonD;
        private System.Windows.Forms.Button twitchButtonD;
        private System.Windows.Forms.Button otherButtonD;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox passwordListBox;
        private System.Windows.Forms.Label warningLabel;
    }
}
