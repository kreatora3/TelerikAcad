/*Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter valid hex number (0-9) and (A - F): ");
        string hex = Console.ReadLine();
        Console.WriteLine();

        char[] array = hex.ToCharArray();
        Array.Reverse(array);

        int deciNum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 'A')
            {
                deciNum += (int)Math.Pow(16, i) * 10;
            }
            else if (array[i] == 'B')
            {
                deciNum += (int)Math.Pow(16, i) * 11;
            }
            else if (array[i] == 'C')
            {
                deciNum += (int)Math.Pow(16, i) * 12;
            }
            else if (array[i] == 'D')
            {
                deciNum += (int)Math.Pow(16, i) * 13;
            }
            else if (array[i] == 'E')
            {
                deciNum += (int)Math.Pow(16, i) * 14;
            }
            else if (array[i] == 'F')
            {
                deciNum += (int)Math.Pow(16, i) * 15;
            }
            else
            {
                deciNum += (int)Math.Pow(16, i) * (array[i] - 48);
            }
        }

        Console.WriteLine(deciNum);
        Console.WriteLine();
    }
}

