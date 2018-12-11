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
    public partial class CurrentPasswordForm : Telerik.WinControls.UI.RadForm
    {
        Methods methods = new Methods();
        public CurrentPasswordForm()
        {
            InitializeComponent();
            BindListBox();
        }

        private void BindListBox()
        {
            passwordBox.DataSource = methods.passwordList;
            passwordBox.DisplayMember = "displayName";
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

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.Show();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.Show();
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

        private void checkStrengthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckStrengthForm csf = new CheckStrengthForm();
            csf.ShowDialog();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.ShowDialog();
        }

        private void passwordBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (passwordBox.SelectedIndex > -1)
            {
                nameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getWebName();
                usernameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getUserName();
                passwordTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getPassword();
                descriptionTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getNotes();
            }
        }

        private void chromeButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Google Chrome"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void gmailButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Gmail"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }


        }

        private void googleDriveButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Google Drive"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }

            }

        }

        private void yahooButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Yahoo"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void outlookButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Outlook"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void amazonButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Amazon"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void facebookButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Facebook"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Instagram"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void snapchatButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Snapchat"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }

        private void twitchButton_Click(object sender, EventArgs e)
        {
            string fileName = "PasswordData.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');
                    string webName = tempArr[0];

                    if (webName.Equals("Twitch"))
                    {
                        nameTextBox.Text = webName;
                        usernameTextBox.Text = tempArr[1];
                        passwordTextBox.Text = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        descriptionTextBox.Text = tempArr[3];

                        break;
                    }
                }
            }

        }
    }
}

