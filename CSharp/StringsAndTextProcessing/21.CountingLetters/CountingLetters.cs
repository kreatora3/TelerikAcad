/*Write a program that reads a string from the console and prints all different letters
 in the string along with information how many times each letter is found.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CountingLetters
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints 
                        all different letters in the string along with information how many 
                        times each letter is found.";


        Dictionary<string, int> result = new Dictionary<string, int>();
        StringBuilder letters = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                letters.Append(text[i].ToString().ToLower());
            }
        }

        while (letters.Length != 0)
        {
            int startingInx = 0;
            int counter = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[startingInx] == letters[startingInx+i])
                {
                    counter++;
                }
            }

            result.Add(letters[startingInx].ToString(), counter);
            letters = letters.Replace(letters[startingInx].ToString(), string.Empty);
        }

        foreach (var item in result)
        {
            Console.WriteLine("Letter {0} is found {1} times", item.Key, item.Value);
        }
    }
}

