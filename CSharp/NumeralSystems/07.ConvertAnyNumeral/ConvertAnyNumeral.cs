/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ConvertAnyNumeral
{
    static void Main()
    {

        Console.Write("Please enter your number: ");
        string theNumber = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Base of your number is: ");
        int numBase = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("To be converted in number with base of: ");
        int toBase = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (numBase == toBase)
        {
            Console.WriteLine(theNumber);
        }

        else
        {
            char currentChar = new char();
            int digit = new int();
            int number = 0;

            for (int i = 0; i < theNumber.Length; i++)
            {
                currentChar = theNumber[i];
                if (currentChar >= 'a')
                {
                    digit = currentChar - 'a' + 10;
                }
                else
                {
                    digit = currentChar - '0';
                }
                number += (int)(digit * Math.Pow((double)numBase, (theNumber.Length - i - 1)));
            }

            string numberOutput = string.Empty;

            while (number != 0)
            {
                int remainder = number % toBase;
                if (remainder <= 9)
                {
                    numberOutput = remainder + numberOutput;
                }
                else
                {
                    numberOutput = ((char)('A' + remainder - 10)) + numberOutput;
                }
                number /= toBase;
            }
            Console.WriteLine("The result is {0}", numberOutput);
            Console.WriteLine();
        }
    }
}

