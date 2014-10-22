﻿/*We are given a string containing a list of forbidden words and a text containing some of these words. 
 Write a program that replaces the forbidden words with asterisks. Example:
 
 Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
 implemented as a dynamic language in CLR.
	
		Words: "PHP, CLR, Microsoft"
		
 The expected result:
 
 * ********* announced its next generation *** compiler today. 
 It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and isimplemented as a dynamic language in CLR.";
                        

        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine();
        Console.WriteLine(text);
    }
}

