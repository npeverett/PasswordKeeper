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
            Random rand = new Random();
            string newPassword = "";
            int numSymbols = 0;
            int numNumbers = 0;
            int numLower = 0;
            int numUpper = 0;

            char[] safeSymbols = { '!', '@', '#', '$', '"', '-', '`', '~' };
            char[] safeNumbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] safeLowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] safeUpperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            while (newPassword.Length < 8)
            {
                int r = rand.Next(4);
                if (r == 1 && numSymbols <= 2)
                {
                    int idx = rand.Next(safeSymbols.Length);
                    while (newPassword.Contains(safeSymbols[idx]) == true)
                    {
                       idx = rand.Next(safeSymbols.Length);
                    }
                    newPassword += safeSymbols[idx];
                }
                if (r == 2 && numNumbers <= 2)
                {
                    int idx = rand.Next(safeNumbers.Length);
                    while (newPassword.Contains(safeNumbers[idx]) == true)
                    {
                        idx = rand.Next(safeNumbers.Length);
                    }
                    newPassword += safeNumbers[idx];
                }
                if (r == 3 && numLower <= 2)
                {
                    int idx = rand.Next(safeLowerLetters.Length);
                    while (newPassword.Contains(safeLowerLetters[idx]) == true)
                    {
                        idx = rand.Next(safeLowerLetters.Length);
                    }
                    newPassword += safeLowerLetters[idx];
                }
                if (r == 4 && numUpper <= 2)
                {
                    int idx = rand.Next(safeUpperLetters.Length);
                    while (newPassword.Contains(safeUpperLetters[idx]) == true)
                    {
                        idx = rand.Next(safeUpperLetters.Length);
                    }
                    newPassword += safeUpperLetters[idx];
                }
            }
            newPasswordLabel.Text = newPassword;
        }
    }
}
