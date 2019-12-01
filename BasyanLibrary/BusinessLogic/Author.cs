using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Author
    {
        private int _id;
        private string _name;
        private readonly DateTime _dob;
        private string _country;
        private List<Genre> _genres;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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

        public DateTime Dob => _dob;

        public Author(int id, string name, DateTime dob, string country)
        {
            Id = id;
            Name = name;
            Country = country;
            _dob = dob;
        }
    }
}