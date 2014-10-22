using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
      
        List<string> words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        for (int i = 0; i < words.Count; i++)
        {
            int position = words[i].Length % (n + 1);
            string temp = words[i];
            words[i] = null;
            words.Insert(position, temp);
            words.Remove(null);
            //words.Insert(position, null);
            //words.Remove(temp);
            //words.Insert(position, temp);
            //words.Remove(null);
        }

        StringBuilder print = new StringBuilder();

        int currentWord = 0;
        int indx = 0;

        int resultLen = 0;
        for (int i = 0; i < words.Count; i++)
        {
            resultLen += words[i].Length;
        }
       
        while (print.Length != resultLen)
        {
            if (indx < words[currentWord].Length)
            {
                print.Append(words[currentWord][indx]);
            }
            
            currentWord++;
            if (currentWord == words.Count)
            {
                currentWord = 0;
                indx++;
            }
        }
        Console.WriteLine(print.ToString());
    }
}

