/*Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.*/
namespace WriteJpegFiles
{
    using System.Data.SqlClient;
    using System.IO;

    class WriteJpegFiles
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server = .\\SQLEXPRESS; Database = Northwind; Integrated security = true; ");

            dbCon.Open();

            using (dbCon)
            {
                var getImages = new SqlCommand("Select CategoryName, Picture from Categories", dbCon);

                var reader = getImages.ExecuteReader();

                using (reader)
                {
                    byte[] pictures;
                    string categoryName;
                    while (reader.Read())
                    {
                        pictures = (byte[])reader["Picture"];
                        categoryName = (string)reader["CategoryName"];
                        categoryName = categoryName.Replace("/", string.Empty);
                        WriteBinaryFile(@"..\..\" + categoryName + ".JPG", pictures);
                    }
                }
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 78, fileContents.Length - 78);
            }
        }
    }
}
