/*Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.*/
namespace AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    class AddProduct
    {
        static void Main()
        {

            int id = 1;
            string name = "NewAddedProduct";
            decimal price = 22.20M;

            SqlConnection dbCon = new SqlConnection("Server = .\\SQLEXPRESS; Database = Northwind; Integrated security = true; ");

           dbCon.Open();

           
               SqlCommand insertProduct = new SqlCommand("Insert into Products (SupplierID, ProductName, UnitPrice)" +
                                                       " Values(@id, @name, @price)", dbCon);
            insertProduct.Parameters.AddWithValue("@id", id);
            insertProduct.Parameters.AddWithValue("@name", name);
            insertProduct.Parameters.AddWithValue("@price", price);

            using (dbCon)
            {
                insertProduct.ExecuteNonQuery();

                SqlCommand selectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
                int insertedId = (int)(decimal)selectIdentity.ExecuteScalar();
                Console.WriteLine("Product name : {0},\n Unit price : {1},\n Supplier ID : {2},\n Product ID : {3}", name, price, id, insertedId);
            }           
        }
    }
}
