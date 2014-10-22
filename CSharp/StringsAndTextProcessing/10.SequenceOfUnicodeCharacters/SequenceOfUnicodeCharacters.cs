/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
  Sample input:
                Hi!
		Expected output:
  \u0048\u0069\u0021

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SequenceOfUnicodeCharacters
{
    static void Main()
    {
        string s = "Hi!";

        for (int i = 0; i < s.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)(s[i]));
           
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

