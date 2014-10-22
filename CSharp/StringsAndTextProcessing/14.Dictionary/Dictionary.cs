/*A dictionary is stored as a sequence of text lines containing words and their explanations. 
 Write a program that enters a word and translates it by using the dictionary. 
 Sample dictionary:
 
 * .NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> itDict = new Dictionary<string, string>();

        itDict.Add(".NET", "– platform for applications from Microsoft");
        itDict.Add("CLR", "– managed execution environment for .NET");
        itDict.Add("namespace", "hierarchical organization of classes");
                

        while (true)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine();

            if (itDict.ContainsKey(word))
            {
                Console.WriteLine("{0} {1}",word, itDict[word]);
            }
            else
            {
                Console.WriteLine("Sorry, word not found");
            }
            
        }
    }
}

