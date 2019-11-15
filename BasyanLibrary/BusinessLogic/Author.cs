using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Author
    {
        private string _name;
        private DateTime _dob;
        private string _country;
        private List<Genre> _genres;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public List<Genre> Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        public Author(string name, DateTime dob, List<Genre> genres, string country)
        {
            Name = name;
            DOB = dob;
            Genres = genres;
            Country = country;
        }
    }
}