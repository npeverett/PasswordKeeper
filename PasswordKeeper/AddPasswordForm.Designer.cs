namespace PasswordKeeper
{
    partial class AddPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPasswordForm));
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.randomGenLabel = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.savePassword = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.analyzeLabel = new System.Windows.Forms.Label();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.removePassButton.Click += new System.EventHandler(this.removePassButton_Click);
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
            this.currentPasswords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.currentPasswords.FlatAppearance.BorderSize = 0;
            this.currentPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPasswords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswords.ForeColor = System.Drawing.Color.White;
            this.currentPasswords.Image = ((System.Drawing.Image)(resources.GetObject("currentPasswords.Image")));
            this.currentPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Impact", 24.75F);
            this.headerLabel.Location = new System.Drawing.Point(585, 59);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(215, 41);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "New Password";
            // 
            // randomGenLabel
            // 
            this.randomGenLabel.AutoSize = true;
            this.randomGenLabel.Location = new System.Drawing.Point(787, 285);
            this.randomGenLabel.Name = "randomGenLabel";
            this.randomGenLabel.Size = new System.Drawing.Size(294, 15);
            this.randomGenLabel.TabIndex = 4;
            this.randomGenLabel.Text = "Want a randomly generated safe password? Click here.\r\n";
            // 
            // randomizeButton
            // 
            this.randomizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.randomizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.randomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeButton.Location = new System.Drawing.Point(896, 312);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(97, 31);
            this.randomizeButton.TabIndex = 5;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = false;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // savePassword
            // 
            this.savePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.savePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePassword.Location = new System.Drawing.Point(550, 601);
            this.savePassword.Name = "savePassword";
            this.savePassword.Size = new System.Drawing.Size(211, 59);
            this.savePassword.TabIndex = 6;
            this.savePassword.Text = "Save Password";
            this.savePassword.UseVisualStyleBackColor = false;
            this.savePassword.Click += new System.EventHandler(this.savePassword_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(335, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 15);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Website Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(335, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(338, 373);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(341, 152);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 29);
            this.nameTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(341, 312);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(274, 29);
            this.passwordTextBox.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(341, 404);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(274, 124);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.Text = "";
            // 
            // analyzeLabel
            // 
            this.analyzeLabel.AutoSize = true;
            this.analyzeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeLabel.Location = new System.Drawing.Point(632, 315);
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(0, 21);
            this.analyzeLabel.TabIndex = 13;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(622, 285);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(105, 15);
            this.passwordStrengthLabel.TabIndex = 14;
            this.passwordStrengthLabel.Text = "Password Strength";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(341, 227);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(274, 29);
            this.usernameTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordStrengthLabel);
            this.Controls.Add(this.analyzeLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.savePassword);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.randomGenLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panelCurrPass);
            this.Controls.Add(this.panelLEFT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1188, 752);
            this.MinimumSize = new System.Drawing.Size(1188, 752);
            this.Name = "AddPasswordForm";
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
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label randomGenLabel;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button savePassword;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label analyzeLabel;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
    }
}