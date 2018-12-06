namespace PasswordKeeper
{
    partial class CurrentPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentPasswordForm));
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.logoLabel = new System.Windows.Forms.Label();
            this.panelLEFT = new System.Windows.Forms.Panel();
            this.cpyrtLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.removePassButton = new System.Windows.Forms.Button();
            this.addPassButton = new System.Windows.Forms.Button();
            this.genNewPassButton = new System.Windows.Forms.Button();
            this.currentPasswords = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panelCurrPass = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
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
            this.panelLEFT.Controls.Add(this.cpyrtLabel);
            this.panelLEFT.Controls.Add(this.companyLabel);
            this.panelLEFT.Controls.Add(this.removePassButton);
            this.panelLEFT.Controls.Add(this.addPassButton);
            this.panelLEFT.Controls.Add(this.genNewPassButton);
            this.panelLEFT.Controls.Add(this.currentPasswords);
            this.panelLEFT.Controls.Add(this.logoPanel);
            this.panelLEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLEFT.Location = new System.Drawing.Point(0, 0);
            this.panelLEFT.Name = "panelLEFT";
            this.panelLEFT.Size = new System.Drawing.Size(200, 719);
            this.panelLEFT.TabIndex = 1;
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
            this.removePassButton.MouseHover += new System.EventHandler(this.removePassButton_MouseHover);
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
            this.addPassButton.MouseHover += new System.EventHandler(this.addPassButton_MouseHover);
            // 
            // genNewPassButton
            // 
            this.genNewPassButton.BackColor = System.Drawing.Color.Transparent;
            this.genNewPassButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.genNewPassButton.FlatAppearance.BorderSize = 0;
            this.genNewPassButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genNewPassButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genNewPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genNewPassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.genNewPassButton.ForeColor = System.Drawing.Color.Transparent;
            this.genNewPassButton.Image = ((System.Drawing.Image)(resources.GetObject("genNewPassButton.Image")));
            this.genNewPassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genNewPassButton.Location = new System.Drawing.Point(0, 237);
            this.genNewPassButton.Name = "genNewPassButton";
            this.genNewPassButton.Size = new System.Drawing.Size(200, 106);
            this.genNewPassButton.TabIndex = 2;
            this.genNewPassButton.Text = "Generate New Random Password";
            this.genNewPassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genNewPassButton.UseVisualStyleBackColor = false;
            this.genNewPassButton.MouseHover += new System.EventHandler(this.genNewPassButton_MouseHover);
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
            this.currentPasswords.MouseHover += new System.EventHandler(this.currentPasswords_MouseHover);
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
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.descriptionLabel.Location = new System.Drawing.Point(284, 618);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 30);
            this.descriptionLabel.TabIndex = 0;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(206, 397);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(0, 15);
            this.newPasswordLabel.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.passwordTextBox.Location = new System.Drawing.Point(400, 298);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(261, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(400, 251);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 13;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(400, 211);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 14;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(400, 360);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 96);
            this.notesTextBox.TabIndex = 15;
            this.notesTextBox.Text = "";
            // 
            // CurrentPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 719);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.panelCurrPass);
            this.Controls.Add(this.panelLEFT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1188, 752);
            this.MinimumSize = new System.Drawing.Size(1188, 752);
            this.Name = "CurrentPasswordForm";
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
        private System.Windows.Forms.Button genNewPassButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label cpyrtLabel;
        private System.Windows.Forms.Panel panelCurrPass;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.RichTextBox notesTextBox;
    }
}