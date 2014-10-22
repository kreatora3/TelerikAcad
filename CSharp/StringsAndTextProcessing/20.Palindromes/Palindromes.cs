/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Palindromes
{
    static void Main()
    {
        string text = @"The most familiar palindromes, in English at least, are character-by-character: 
                        The written characters read the same backward as forward.
                        Some examples of common palindromic words: civic, radar, level, rotor, noon, kayak, reviver,
                        racecar, redder, madam, Malayalam, and refer. ";

        string[] words = text.Split(new char[] { ' ', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            bool palindromeWord = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    palindromeWord = false;
                    break;
                }
            }
            if (palindromeWord && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}

