using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Book
    {
        private readonly int _id;
        private readonly string _title;
        private readonly Author _author;
        private Genre[] _genres;
        private readonly int _year;

        public int Id
        {
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
        }

        public Author Author
        {
            get { return _author; }
        }

        public Genre[] Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        public int Year
        {
            get { return _year; }
        }

        public Book(int id, string title, Author author, Genre[] genres, int year)
        {
            _id = id;
            _title = title;
            _author = author;
            Genres = genres;
            _year = year;
        }

    }
}