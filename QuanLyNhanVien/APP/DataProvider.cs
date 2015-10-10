using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace APP
{
    public class DataProvider
    {
        private static string Connectionstring;

        public static string Connectionstring1
        {
            get { return DataProvider.Connectionstring; }
            set { DataProvider.Connectionstring = value; }
        }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        public void OpenConnec()
        {
            connection = new SqlConnection(Connectionstring1);
            connection.Open();

        }
        public void CloseConnec()
        {
            connection.Close();
        }

     public DataTable executeReader(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            adapter.Fill(tb);
            return tb;
        }
        public void executeNonQuery(string sql)
     {
         command = new SqlCommand(sql, connection);
         command.ExecuteNonQuery();
     }
    }
}
