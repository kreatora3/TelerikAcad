/*Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Text;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter valid hex number (0-9) and (A - F): ");
        string hex = Console.ReadLine();
        Console.WriteLine();

        
        StringBuilder binary = new StringBuilder();

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0': binary.Append("0000");
                    break;
                case '1': binary.Append("0001");
                    break;
                case '2': binary.Append("0010");
                    break;
                case '3': binary.Append("0011"); 
                    break;
                case '4': binary.Append("0100");
                    break;
                case '5': binary.Append("0101");
                    break;
                case '6': binary.Append("0110"); 
                    break;
                case '7': binary.Append("0111"); 
                    break;
                case '8': binary.Append("1000"); 
                    break;
                case '9': binary.Append("1001"); 
                    break;
                case 'A': binary.Append("1010"); 
                    break;
                case 'B': binary.Append("1011"); 
                    break;
                case 'C': binary.Append("1100"); 
                    break;
                case 'D': binary.Append("1101"); 
                    break;
                case 'E': binary.Append("1110"); 
                    break;
                case 'F': binary.Append("1111"); 
                    break;
                default: Console.WriteLine();
                    break;
            }
        }

        string result = binary.ToString();

        Console.WriteLine(result.TrimStart('0'));
        Console.WriteLine();
    }
}

