/*Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.*/

namespace NumberOfRows
{
    using System;
    using System.Data.SqlClient;

    class NumberOfrows
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server = .\\SQLEXPRESS; Database = Northwind; Integrated security = true;");

            dbCon.Open();

            using (dbCon)
            {
                var command = new SqlCommand("Select count (*) from Categories", dbCon);
                int rowCount = (int)command.ExecuteScalar();
                Console.WriteLine("There are {0} rows in Categories", rowCount);
            }
        }
    }
}
