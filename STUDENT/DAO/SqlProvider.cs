using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    public class SqlProvider
    {
        public static string connectionString = @"Data Source=DESKTOP-R1F13KN;Initial Catalog=QLHS;Integrated Security=True";
        public static SqlConnection connection = null;

        public static void OpenConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection != null)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection != null)
                connection.Close();
        }

        public static void ExecuteNoneQuery(string query)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public static DataTable ExecuteQuery(string query)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
     }
}
