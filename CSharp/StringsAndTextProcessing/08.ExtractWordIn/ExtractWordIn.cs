/*Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
 
 We are living in a yellow submarine. We don't have anything else. 
 Inside the submarine is very tight. So we are drinking all the day.
 We will move out of it in 5 days.

		The expected result is:

We are living in a yellow submarine.
We will move out of it in 5 days.

		Consider that the sentences are separated by "." and the words – by non-letter symbols.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExtractWordIn
{
    static void Main()
    {
        string textStr = @"We are living in a yellow submarine. We don't have anything else. 
 Inside the submarine is very tight. So we are drinking all the day.
 We will move out of it in 5 days.";

        List<string> toPrint = new List<string>();

        string[] senteces = textStr.Split('.');

        for (int i = 0; i < senteces.Length; i++)
        {
            string temp = senteces[i];
           
            for (int j = 0; j < senteces[i].Length; j++)
            {
               
                if (temp[j] == 'i' && temp[j+1] == 'n')
                {
                    if ((j>0 && char.IsLetter(temp[j-1])) && (j<temp.Length-1 && char.IsLetter(temp[j+2])))
                    {
                        continue;
                    }
                    else
                    {
                        toPrint.Add(senteces[i]);
                    }
                }
            }
        }

     foreach (var sentence in toPrint)
	{
		 Console.WriteLine(sentence.Replace("\r\n", string.Empty).Trim());
         Console.WriteLine();
	}
	
    }
}

