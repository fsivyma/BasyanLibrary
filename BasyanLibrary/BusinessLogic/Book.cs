using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Book
    {
        private readonly string _title;
        private readonly Author _author;
        private Genre[] _genres;
        private readonly int _year;
        private readonly int _pageCount;
     
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

        public int PageCount
        {
            get { return _pageCount; }
        }

        public Book(string title, Author author, Genre[] genres, int year, int pageCount)
        {
            _title = title;
            _author = author;
            Genres = genres;
            _year = year;
            _pageCount = pageCount;
        }

    }
}