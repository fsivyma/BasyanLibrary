using BasyanLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasyanLibrary.DAL
{
    public class AuthorDAO
    {
        private SqlDataAdapter _authorDataAdapter;
        private DataTable _authorTable;

        private string _conString;

        public AuthorDAO(string conString)
        {
            _conString = conString;

            _authorDataAdapter = new SqlDataAdapter("select * from Author", _conString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_authorDataAdapter);
            _authorTable = new DataTable();
            _authorDataAdapter.Fill(_authorTable);
        }

        public List<Author> ReadAll(string namePattern = "")
        {
            List<Author> authorList = new List<Author>();

            DataRow[] rows = _authorTable.Select($"Name like '%{namePattern}%'");

            foreach (DataRow row in rows)
            {
                Author person = new Author(row.Field<int>(0), row.Field<string>(1), row.Field<DateTime>(2), row.Field<string>(3));
                authorList.Add(person);
            }

            return authorList;
        }

        public void AddRecord(int id, string name, DateTime dob, string country)
        {
            _authorTable.Rows.Add(id, name, dob, country); //added to local copy
            _authorDataAdapter.Update(_authorTable); //changes pushed to DB
        }

        public int DeleteRecord(int id)
        {
            DataRow[] rows = _authorTable.Select($"AuthorId = {id}");
            foreach (DataRow row in rows)
                row.Delete(); //deleted from local copy
            _authorDataAdapter.Update(_authorTable); //changes pushed to DB
            return rows.Length;
        }
    }
}

