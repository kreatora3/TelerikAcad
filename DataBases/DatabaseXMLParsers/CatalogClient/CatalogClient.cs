namespace CatalogClient
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class CatalogClient
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\catalog.xml");
            var authors = new Dictionary<string,int>();
            
         
            XmlNode rootNode = doc.DocumentElement;
            var albums = rootNode.ChildNodes;
           
            foreach (XmlNode album in albums)
            {
                foreach (XmlNode item in album.ChildNodes)
                {
                    var artist = item["artist"].InnerText;
                    
                    if (!authors.ContainsKey(artist))
                    {
                        int count = 0;
                        authors.Add(artist, count); 
                    }
                   
                    authors[artist] += 1;
                } 
            }

            foreach (KeyValuePair<string, int> item in authors)
            {
                Console.WriteLine("{0} has {1} albums in the catalog", item.Key, item.Value);
            }
        }
    }
}
