using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordKeeper
{
    class Methods
    {
        public string genNewPassword()
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

            while (newPassword.Length < 12)
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

            return newPassword;
        }

        public bool checkSymbols(string password)
        {
            char[] safeSymbols = { '!', '@', '#', '$', '"', '-', '`', '~' };

            for(int i = 0; i < password.Length; i++)
            {
                if(password.Contains(safeSymbols[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkNumbers(string password)
        {
            char[] safeNumbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for(int i = 0; i < password.Length; i++)
            {
                if(password.Contains(safeNumbers[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkLowerCase(string password)
        {
            char[] safeLowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            for(int i = 0; i < password.Length; i++)
            {
                if(password.Contains(safeLowerLetters[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkUpperCase(string password)
        {
            char[] safeUpperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            for(int i = 0; i < password.Length; i++)
            {
                if(password.Contains(safeUpperLetters[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool analyzePassword(string password)
        {
            if (password.Length < 12 || checkSymbols(password) == false || checkNumbers(password) == false || checkLowerCase(password) == false || checkUpperCase(password) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
