/*Write a program that reads from the console a string of maximum 20 characters. 
 If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 Print the result string into the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TwentyCharactersString
{
    static void Main()
    {
        Console.Write("Enter something: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("If the input is less than 20 characters this program will fill it to 20 with '*'");
        Console.WriteLine();
        Console.WriteLine(input.PadRight(20, '*'));
        Console.WriteLine();
    }
}

