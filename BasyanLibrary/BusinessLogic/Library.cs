using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Library
    {
        private User _user;
        
        // Each book in the user library has the page number that the user
        // is currently on associated with it.
        private Dictionary<Book, int> _books = new Dictionary<Book, int>();

        public User User 
        {
            get { return _user; }
            set { _user = value; }
        }
        public Dictionary<Book, int> Books 
        {
            get { return _books; }
            set { _books = value; }
        }

        public Library(User user)
        {
            User = user;
        }

        public Library(User user, Dictionary<Book, int> books)
        {
            User = user;
            Books = books;
        }

    }
}