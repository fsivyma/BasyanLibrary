using BasyanLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasyanLibrary.DAL
{
    public class GenreDAO
    {
        private SqlDataAdapter _genreDataAdapter, _bookGenreAdapter;
        private DataTable _genreTable, _bookGenreTable;

        private string _conString;
        public GenreDAO(string conString)
        {
            _conString = conString;

            _genreDataAdapter = new SqlDataAdapter("select * from Genre", _conString);
            _bookGenreAdapter = new SqlDataAdapter("select * from BookGenre", _conString);

            SqlCommandBuilder genreSqlCommandBuilder = new SqlCommandBuilder(_genreDataAdapter);
            SqlCommandBuilder bookGenreSqlCommandBuilder = new SqlCommandBuilder(_bookGenreAdapter);

            _genreTable = new DataTable();
            _genreDataAdapter.Fill(_genreTable);

            _bookGenreTable = new DataTable();
            _bookGenreAdapter.Fill(_bookGenreTable);
        }

        public List<Genre> GetBookGenre(int bookId)
        {
            List<Genre> bookGenres = new List<Genre>();

            DataRow[] rows = _bookGenreTable.Select($"BookId = '%{bookId}%'");

            foreach (DataRow row in rows)
            {
                Genre bookGenre = (Genre)Enum.Parse(typeof(Genre), row.Field<string>(1));
                bookGenres.Add(bookGenre);
            }

            return bookGenres;
        }s
    }
}