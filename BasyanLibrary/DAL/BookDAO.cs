using BasyanLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasyanLibrary.DAL
{
    public class BookDAO
    {
        private List<Author> _authors;

        private SqlDataAdapter _bookDataAdapter;
        private DataTable _bookTable;

        private string _conString;

        public BookDAO(string conString, List<Author> authors)
        {
            _authors = authors;
            _conString = conString;

            _bookDataAdapter = new SqlDataAdapter("select * from Book", _conString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_bookDataAdapter);
            _bookTable = new DataTable();
            _bookDataAdapter.Fill(_bookTable);
        }

        public List<Book> ReadAll(string namePattern = "")
        {
            List<Book> bookList = new List<Book>();

            DataRow[] rows = _bookTable.Select($"name like '%{namePattern}%'");

            foreach (DataRow row in rows)
            {
                int id = row.Field<int>(0);
                GenreDAO genreDAO = new GenreDAO(_conString);

                Author bookAuthor = null;

                foreach(Author author in _authors)
                {
                    if (author.Id.Equals(row.Field<int>(2)))
                        bookAuthor = author;
                }

                Book book = new Book(id, row.Field<string>(1), bookAuthor, genreDAO.GetBookGenre(id).ToArray(), row.Field<DateTime>(3).Year);
                bookList.Add(book);
            }

            return bookList;
        }

        public void AddRecord(int id, string title, Author author, DateTime dob)
        {
            _bookTable.Rows.Add(id, title, author, dob); //added to local copy
            _bookDataAdapter.Update(_bookTable); //changes pushed to DB
        }

        public int DeleteRecord(int id)
        {
            DataRow[] rows = _bookTable.Select($"Id={id}");
            foreach (DataRow row in rows)
                row.Delete(); //deleted from local copy
            _bookDataAdapter.Update(_bookTable); //changes pushed to DB
            return rows.Length;
        }
    }
}
}