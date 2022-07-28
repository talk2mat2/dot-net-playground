using System;
using System.Data.SqlClient;
using System.Text;


namespace ConsoleApp1
{
    class Database
    {
        string connectionString = @"Server=DESKTOP-TA7CD5T;Database=console;User Id=console;Password=console;";
        public void fetch()
        {
            

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
    
    public void Insert()
        {
            

          

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;

                try
                {
                    connection.Open();

                    Console.WriteLine("State: {0}", connection.State);
                    Console.WriteLine(" connected, ConnectionString: {0}",
                        connection.ConnectionString);
                    StringBuilder strBuilder = new StringBuilder();
                    strBuilder.Append("INSERT INTO users (Name, Email) VALUES ");
                    strBuilder.Append("(N'Harsh', N'harsh@gmail.com'), ");
                    strBuilder.Append("(N'Harsh', N'harsh@gmail.com'), ");
                    strBuilder.Append("(N'Harsh', N'harsh@gmail.com'), ");
                    strBuilder.Append("(N'Harsh', N'harsh@gmail.com') ");


                    string sqlQuery = strBuilder.ToString();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection)) //pass SQL query created above and connection
                    {
                        command.ExecuteNonQuery(); //execute the Query
                        Console.WriteLine("Query Executed.");
                    }

                    strBuilder.Clear();
                    connection.Close();

                }
                catch(Exception e)
                {
                    Console.WriteLine("failue" + e);
                }
                }
            


        }
    
    }
}
