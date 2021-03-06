﻿/*Write a program that reads a string from the console and replaces all series of consecutive 
 identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class IdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();

        result.Append(text[0]);
        
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i-1])
            {
                result.Append(text[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }
}

