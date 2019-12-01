using BasyanLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasyanLibrary.DAL
{
    public class UserDAO
    {
        private SqlDataAdapter _userDataAdapter;
        private DataTable _userTable;

        private string _conString;

        public UserDAO(string conString)
        {
            _conString = conString;

            _userDataAdapter = new SqlDataAdapter("select * from User", _conString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userDataAdapter);
            _userTable = new DataTable();
            _userDataAdapter.Fill(_userTable);
        }

        public List<User> ReadAll(string namePattern = "")
        {
            List<User> userList = new List<User>();

            DataRow[] rows = _userTable.Select($"name like '%{namePattern}%'");

            foreach (DataRow row in rows)
            {
                User user = new User(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2));
                userList.Add(user);
            }

            return userList;
        }
    }
}