/*You are given a text. Write a program that changes the text in all regions
 surrounded by the tags <upcase> and </upcase> to uppercase. 
 
 * The tags cannot be nested. Example:
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result:
 We are living in a YELLOW SUBMARINE. We don't have ANYTHING else*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class UpperCaseTag
{
    static string TextToUpper(StringBuilder formated)
    {
        bool inUpperTag = false;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < formated.Length; i++)
        {
            if (inUpperTag)
            {
                if (formated[i] == '<' && formated[i + 1] == '/')
                {
                    i += 8;
                    inUpperTag = false;
                    continue;
                }
                else
                {
                    result.Append(Char.ToUpper(formated[i]));
                    continue;
                }
            }

            if (formated[i] == '<')
            {
                inUpperTag = true;
                i += 7;
                continue;
            }
            else
            {
                result.Append(formated[i]);
            }
        }

        return result.ToString();
    }
   
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";       
      
        StringBuilder formated = new StringBuilder(text);

        Console.WriteLine(TextToUpper(formated));
        

	}
   
      
}

