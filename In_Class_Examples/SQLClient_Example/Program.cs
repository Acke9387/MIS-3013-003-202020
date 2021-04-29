using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SQLClient_Example
{
    class Program
    {
        static void Main(string[] args)
        {            
            string connectionString = "Data Source=tcp:s13.winhost.com;Initial Catalog=DB_128040_practice;User ID=student;Password=AdamTheGreat2020;Integrated Security=False;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT StudentID, FirstName, LastName, FavoriteColor " +
                                                               "FROM Student", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            //Loop through each row returned from the database
                            int id = Convert.ToInt32(reader["StudentID"]);
                            string first = reader[1].ToString();
                            string last = reader["LastName"].ToString();
                            string color = reader[3].ToString();

                            //Student s = new Student();
                            //s.First = first;
                            //s.Last = last;
                            //s.ID = id;
                            //s.FavoriteColor = color;

                            if (color.ToLower().Contains("blue") == true)
                            {
                                Console.WriteLine($"{first} {last} ({id}) likes {color}");

                            }
                        }
                        reader.Close();
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }

            }

        }
    }
}
