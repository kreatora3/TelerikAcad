/*Write a program to convert decimal numbers to their binary representation.*/

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int copy = decimalNumber;
        List<int> binary = new List<int>();

        while (decimalNumber > 0)
        {
            binary.Add(decimalNumber % 2);
            decimalNumber /= 2;
        }

        binary.Reverse();

        Console.Write("Binary representation of {0} is: ", copy);
        foreach (var member in binary)
        {
            
            Console.Write(string.Join("", member));
           
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

