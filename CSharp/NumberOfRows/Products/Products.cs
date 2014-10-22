/*Write a program that retrieves from the Northwind database all product categories and 
 the names of the products in each category. Can you do this with a single SQL query (with table join)?*/
namespace Products
{
    using System;
    using System.Data.SqlClient;

    class Products
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server = .\\SQLEXPRESS; Database = Northwind; Integrated security = true; ");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand("Select c.CategoryName, p.ProductName from Categories c" +
                                            " Join Products p ON c.CategoryID = p.CategoryID" +
                                            " GROUP BY c.CategoryName, p.ProductName", dbCon);
               
                SqlDataReader reader = command.ExecuteReader();
              
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} : {1}", (string)reader["CategoryName"], (string)reader["ProductName"]);
                    }
                }
            }
        }
    }
}
