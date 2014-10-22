/*Write a program that parses an URL address given in the format:
 
 [protocol]://[server]/[resource]

  and extracts from it the [protocol], [server] and [resource] elements. 
  For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ParsingURL
{
    static void Main()
    {
        string url = @"http://www.devbg.org/forum/index.php";

        bool inProtocol = true;
        bool inServer = false;
        bool inResource = false;

        StringBuilder words = new StringBuilder();
        List<string> toPrint = new List<string>();

        for (int i = 0; i < url.Length; i++)
        {
            
           
            if (inProtocol)
            {
                if (url[i] == ':')
                {
                    inProtocol = false;
                    toPrint.Add(words.ToString());
                    words = new StringBuilder();
                    inServer = true;
                    i += 3;
                }
                else
                {
                    words.Append(url[i]);
                    continue;
                }
            }
            if (inServer)
            {
                if (url[i] == '/')
                {
                    inServer = false;
                    toPrint.Add(words.ToString());
                    words = new StringBuilder();
                    inResource = true;
                }
                else
                {
                    words.Append(url[i]);
                    continue;
                }
                
            }
            if (inResource)
            {
                words.Append(url[i]);
            }

        }
        toPrint.Add(words.ToString());

        Console.WriteLine("[protocol] = \"{0}\"", toPrint[0]);
        Console.WriteLine("[server] = \"{0}\"", toPrint[1]);
        Console.WriteLine("[resource]= \"{0}\"", toPrint[2]);
        Console.WriteLine();

    }
}

