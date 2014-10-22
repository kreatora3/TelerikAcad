/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int hexNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int copy = hexNumber;
        
        List<char> hex = new List<char>();
        int rem = 0;
        char reminder;

        while (hexNumber > 0)
        {
            rem = hexNumber % 16;
            if (rem == 10 )
            {
                reminder = 'A';
            }
            else if (rem == 11)
            {
                reminder = 'B';
            }
            else if (rem == 12)
            {
                reminder = 'C';
            }
            else if (rem == 13)
            {
                reminder = 'D';
            }
            else if (rem == 14)
            {
                reminder = 'E';
            }
            else if (rem == 15 )
            {
                reminder = 'F';
            }
            else
            {
                reminder = (char)(rem + 48);
            }
            hex.Add(reminder);
            hexNumber /= 16;
        }

        hex.Reverse();

        Console.Write("Hex representation of {0} is: ", copy);
        foreach (var member in hex)
        {

            Console.Write(string.Join("", member));

        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

