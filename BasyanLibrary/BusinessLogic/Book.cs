using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasyanLibrary.BusinessLogic
{
    public class Book
    {
        private string _title;
        private Author _author;
        private Genre[] _genres;
        private int _year;
        private readonly int _pageCount;
     
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Author Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Genre[] Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
        }

        public Book(string title, Author author, Genre[] genres, int year, int pageCount)
        {
            Title = title;
            Author = author;
            Genres = genres;
            Year = year;
            _pageCount = pageCount;
        }

    }
}