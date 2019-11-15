using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class User
    {
        private string _name;
        private string _username;
        private string _password;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Username 
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User (string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }

    }
}