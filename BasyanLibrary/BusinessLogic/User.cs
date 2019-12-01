using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class User
    {
        private readonly int _id;
        private string _name;
        private string _username;

        public int Id
        {
            get { return _id; }
        }

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

        public User (int id, string name, string username)
        {
            _id = id;
            Name = name;
            Username = username;
        }

    }
}