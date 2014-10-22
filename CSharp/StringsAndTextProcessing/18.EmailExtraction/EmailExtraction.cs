/*Write a program for extracting all email addresses from given text. 
 All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class EmailExtraction
{
    static void Main()
    {
        string text = @"Get custom gmail@gmail.com including calendar, docs, video.com meetings, and more with access from your phone or tablet";
        StringBuilder finder = new StringBuilder();

        bool inEmail = false;
        int afterWhite = 0;
        List<string> result = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (inEmail)
            {
                
                if (text[i] == ' ')
                {
                    inEmail = false;
                    result.Add(finder.ToString().Trim());
                    finder = new StringBuilder();
                    continue;
                }
                else
                {
                    finder.Append(text[i]);
                    continue;
                }
            }

            if (text[i] == ' ' && text[i+1] != ' ')
            {
                afterWhite = 0;
            }
            if (text[i]!= ' ')
            {
                afterWhite++;
            }
            if (text[i] == '@')
            {
                inEmail = true;
                i = i - afterWhite;
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

