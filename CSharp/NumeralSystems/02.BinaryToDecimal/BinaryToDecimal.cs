/*Write a program to convert binary numbers to their decimal representation.*/

using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number (only 0 and 1): ");
        string binary = Console.ReadLine();
        Console.WriteLine();

        char[] array = binary.ToCharArray();
        Array.Reverse(array);

        int deciNum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            deciNum += (int)Math.Pow(2, i) * (array[i]-48);
        }

        Console.WriteLine(deciNum);
        Console.WriteLine();
    }
}

