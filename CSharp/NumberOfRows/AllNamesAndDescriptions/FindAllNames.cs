/*Write a program that retrieves the name and description of all categories in the Northwind DB*/
namespace AllNamesAndDescriptions
{
    using System;
    using System.Data.SqlClient;

    class FindAllNames
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server = .\\SQLEXPRESS; Database = Northwind; Integrated security = true; ");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand("Select CategoryName, Description from Categories", dbCon);
                var reader = command.ExecuteReader();
               
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Name: {0};    Descrpiption: {1}",
                                         (string)reader["CategoryName"],
                                           (string)reader["Description"]);
                    }
                }
            }
        }
    }
}
