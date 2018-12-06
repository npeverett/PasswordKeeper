using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;

namespace PasswordKeeper
{
    public partial class AddPasswordForm : Telerik.WinControls.UI.RadForm
    {
        Methods variable = new Methods();
        BindingList<Password> passwordList;
        
        public AddPasswordForm()
        {
            InitializeComponent();
            passwordList = variable.getPasswordList();

            if(passwordTextBox.Text != "")
            {
                Methods methods = new Methods();

                if(methods.analyzePassword(passwordTextBox.Text) == true)
                {
                    analyzeLabel.Text = "Strong";
                    analyzeLabel.ForeColor = Color.ForestGreen;
                }
                else
                {
                    analyzeLabel.Text = "Weak";
                    analyzeLabel.ForeColor = Color.Red;
                }
            }
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
            Methods methods = new Methods();
            string name = nameTextBox.Text;
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string notes = descriptionTextBox.Text;

            Password newPassword = new Password(name, user, password, notes);

            // Fill in List from stored file
            string fileName = ""; // The file of where we writing the data to
            StreamWriter writer = new StreamWriter(fileName, true);

            string tempLine = name + '|' + user + '|' + methods.encrypt(password, methods.getPassPhrase()) + '|' + notes;

            writer.WriteLine(tempLine);
            
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            string random = methods.genNewPassword();

            passwordTextBox.Text = random;
        }
    }
}
