using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALS
{
    public class DBConnection
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=DARWIN-DEE-TRAD;Initial Catalog=DDT;Integrated Security=True");

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public int ExeNonQuery(SqlCommand command)
        {
            command.Connection = GetConnection();
            int rowsaffected = -1;
            rowsaffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsaffected;
        }
        public object ExeScalar(SqlCommand command)
        {
            command.Connection = GetConnection();
            object obj = -1;
            obj =command.ExecuteScalar();
            connection.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand command)
        {
            
                command.Connection = GetConnection();
                SqlDataReader sqlDataReader;
                DataTable datatable = new DataTable();

                sqlDataReader = command.ExecuteReader();
                datatable.Load(sqlDataReader);
                connection.Close();
                return datatable;
           
            
        }

    }
}
