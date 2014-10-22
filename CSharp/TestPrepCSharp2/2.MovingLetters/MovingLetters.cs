using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MovingLetters
{
    static void Main()
    {
        string s = Console.ReadLine();

        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder firstPart = FirstPart(words);

        string final = Move(firstPart);

        Console.WriteLine(final);
               
       
    }
    

    private static StringBuilder FirstPart(string[] words)
    {
        int maxLen = 0;
       
        for (int i = 0; i < words.Length; i++)
        {
            int currentLen = words[i].Length;
            
            if (currentLen > maxLen)
            {
                maxLen = currentLen;
            }
        }

        StringBuilder text = new StringBuilder();

        for (int i = 0; i < maxLen; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i < words[j].Length) 
                {
                    int last = words[j].Length - 1 - i;
                    text.Append(words[j][last]);
                }
            }
        }

        return text;
    }

    static string Move(StringBuilder firstPart) 
    {
        for (int i = 0; i < firstPart.Length; i++)
        {
            char current = firstPart[i];
            int distance = char.ToLower(current) - 'a' + 1;

            int nextPos = (i + distance) % firstPart.Length;
            firstPart.Remove(i, 1);
            firstPart.Insert(nextPos, current);


        }
        return firstPart.ToString();
    }
}
