using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Data.Expressions;

namespace PasswordKeeper
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        Methods variables = new Methods();
        private BindingList<Password> passwordList;
        private int reusedPassword;
        private int unsafePassword;

        

        public RadForm1()
        {
            InitializeComponent();
            passwordList = variables.getPasswordList();

            numPSW.Text = passwordList.Count.ToString(); 

            for(int i = 0; i < passwordList.Count; i++)
            {
                for(int j = 0; j < passwordList.Count; j++)
                {
                    string tempPassword = passwordList[i].getPassword();
                    string checkPassword = passwordList[j].getPassword();
                    if(tempPassword.Equals(checkPassword))
                    {
                        reusedPassword++;
                    }
                }
            }

            for(int i = 0; i < passwordList.Count; i++)
            {
                Methods method = new Methods();
                if(method.analyzePassword(passwordList[i].getPassword()) == false)
                {
                    unsafePassword++;
                }
            }


            numReusedPSW.Text = reusedPassword.ToString();
            numUnsafePSW.Text = unsafePassword.ToString();

        }

        private void currentPasswords_MouseHover(object sender, EventArgs e)
        {
            //Sets yellow bar to left of current button
            panelCurrPass.Height = currentPasswords.Height;
            panelCurrPass.Top = currentPasswords.Top;
        }

        private void genNewPassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = checkStrengthButton.Height;
            panelCurrPass.Top = checkStrengthButton.Top;
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
            this.Hide();
            CheckStrengthForm csf = new CheckStrengthForm();
            csf.ShowDialog();
        }

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentPasswordForm cpf = new CurrentPasswordForm();
            cpf.ShowDialog();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {

        }

        private void addPassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPasswordForm apf = new AddPasswordForm();
            apf.ShowDialog();
        }

        private void removePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemovePasswordForm rpf = new RemovePasswordForm();
            rpf.ShowDialog();
        }

    }
}
