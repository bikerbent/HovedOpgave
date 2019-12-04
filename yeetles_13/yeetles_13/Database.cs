using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace yeetlse_13
{
    public class Database
    {
        public static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HovedOpgave;Integrated Security=True;";

        public static bool Login(string userName, string password)
        {
            bool verification = false;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand($"SELECT ID FROM UserTable WHERE UserName = '{userName}' AND Password = '{password}'", conn);
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        verification = true;
                    }
                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
                return verification;
            }
        }
    }
}