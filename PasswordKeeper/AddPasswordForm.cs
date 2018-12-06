using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PasswordKeeper
{
    public partial class AddPasswordForm : Telerik.WinControls.UI.RadForm
    {
        public AddPasswordForm()
        {
            InitializeComponent();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.ShowDialog();
        }

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentPasswordForm cpf = new CurrentPasswordForm();
            cpf.ShowDialog();
        }

        private void savePassword_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
            descriptionTextBox.Text = "";
        }
    }
}
