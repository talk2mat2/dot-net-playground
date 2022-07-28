using System;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    class Database
    {
        public Database()
        {
            string connectionString = @"Server=DESKTOP-TA7CD5T;Database=console;User Id=console;Password=console;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                try
                {
                    connection.Open();

                    Console.WriteLine("State: {0}", connection.State);
                    Console.WriteLine("ConnectionString: {0}",
                        connection.ConnectionString);
                  
                    SqlCommand command = new SqlCommand("select * from users;", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            var email=reader["email"];
                            var name = reader["name"];
                            Console.WriteLine(name.ToString() + "" + email);

                            
    }
                    }
                    Console.Read();
                }
                catch(Exception e)
                {
                    Console.WriteLine("unable to connect to sql db {0}", e);
                }
            }
        }
    }
}
