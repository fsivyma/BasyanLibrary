using BasyanLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasyanLibrary.DAL
{
    public class LibraryDAO
    {
        private List<User> _users;
        private List<Book> _books;

        private SqlDataAdapter _libraryDataAdapter;
        private DataTable _libraryTable;

        private string _conString;

        public LibraryDAO(string conString, List<User> users, List<Book> books)
        {
            _users = users;
            _books = books;
            _conString = conString;

            _libraryDataAdapter = new SqlDataAdapter("select * from Library", _conString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_libraryDataAdapter);
            _libraryTable = new DataTable();
            _libraryDataAdapter.Fill(_libraryTable);
        }

        public List<Library> ReadAll(string namePattern = "")
        {
            List<Library> libraryList = new List<Library>();

            DataRow[] rows = _libraryTable.Select($"name like '%{namePattern}%'");

            foreach (DataRow row in rows)
            {
                User libraryUser = null;
                Dictionary<Book, int> books = new Dictionary<Book, int>();
                
                foreach(User user in _users)
                {
                    if (user.Id.Equals(row.Field<int>(0)))
                        libraryUser = user;
                }

                // Need to build dictionary of library books

                Library library = new Library(libraryUser, );
            }

            return libraryList;
        }
    }
}