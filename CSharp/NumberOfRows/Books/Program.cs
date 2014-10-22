﻿namespace Books
{
    using System;
    using MySql.Data.MySqlClient;

    public class MySQLDatabaseOperation
    {
        static void Main()
        {
            string mySqlConnectionString = @"Server=localhost;Port=3306;" +
                "Database=books;Uid=root;Pwd=; pooling=true;";

            MySqlConnection bookDbCon = new MySqlConnection(mySqlConnectionString);
            string title = "Les miserables";
            DateTime publishDate = new DateTime(1862, 12, 1);
            string iSBN = "6789";


            ListAllBooks(bookDbCon);
            Console.WriteLine();

            string titleToFind = "Lord";
            FindBookByName(bookDbCon, titleToFind);
        }

        private static void AddBookToDatabase(string title, DateTime publishDate, string ISBN, MySqlConnection addBookCon)
        {
            MySqlCommand cmdInsertBook = new MySqlCommand(
                "INSERT INTO books (title, publishDate, ISBN) " +
                "VALUES (@title, @publishDate, @ISBN)", addBookCon);
            addBookCon.Open();
            cmdInsertBook.Parameters.AddWithValue("@title", title);
            cmdInsertBook.Parameters.AddWithValue("@publishDate", publishDate);
            cmdInsertBook.Parameters.AddWithValue("@ISBN", ISBN);
            cmdInsertBook.ExecuteNonQuery();
            addBookCon.Close();
        }

        private static void ListAllBooks(MySqlConnection listBooksCon)
        {
            MySqlCommand cmdListBooks = new MySqlCommand(
                "SELECT idBooks, Title, PublishDate, ISBN FROM Books",
                listBooksCon);

            listBooksCon.Open();
            MySqlDataReader reader = cmdListBooks.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
            listBooksCon.Close();
        }

        private static void FindBookByName(MySqlConnection connection, string title)
        {
            string insertSql = "SELECT IdBooks, Title, PublishDate, ISBN FROM Books WHERE Title LIKE @bookName";

            MySqlCommand insertBook = new MySqlCommand(insertSql, connection);

            insertBook.Parameters.AddWithValue("@bookName", "%" + title + "%");

            connection.Open();

            using (MySqlDataReader reader = insertBook.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }

            connection.Close();
        }
    }
}
