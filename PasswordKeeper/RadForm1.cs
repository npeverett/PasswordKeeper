using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private BindingList<Password> passwordList = new BindingList<Password>();

        public RadForm1()
        {
            InitializeComponent();
        }

        private void currentPasswords_MouseHover(object sender, EventArgs e)
        {
            //Sets yellow bar to left of current button
            panelCurrPass.Height = currentPasswords.Height;
            panelCurrPass.Top = currentPasswords.Top;
        }

        private void genNewPassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = genNewPassButton.Height;
            panelCurrPass.Top = genNewPassButton.Top;
        }

        private void addPassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = addPassButton.Height;
            panelCurrPass.Top = addPassButton.Top;
        }

        private void removePassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = removePassButton.Height;
            panelCurrPass.Top = removePassButton.Top;
        }


        private void genNewPassButton_Click(object sender, EventArgs e)
        {
            // Application.Run(new RadForm3());
            Methods method = new Methods();

            string newPassword = method.genNewPassword();

             newPasswordLabel.Text = newPassword;
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

        }

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            // Application.Run(new RadForm2());
        }
    }
}
