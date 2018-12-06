using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordKeeper
{
    class Password
    {
        private string passwordName;
        private string userName;
        private string password;
        private string URL;
        private string notes;

        public Password()
        {
            passwordName = "";
            userName = "";
            password = "";
        }

        public Password(string name, string user, string pass, string url, string note)
        {
            passwordName = name;
            userName = user;
            password = pass;
            URL = url;
            notes = note;
        }
    }
}
