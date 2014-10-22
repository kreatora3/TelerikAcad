/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinToHex
{
    static void Main()
    {
        Console.Write("Enter binary number (only 0 and 1): ");
        string binary = Console.ReadLine();
        Console.WriteLine();
        binary = binary.PadLeft(32, '0');
        
          

        StringBuilder hex = new StringBuilder();

        for (int i = 0; i < binary.Length; i += 4)
        {
            switch (binary.Substring(i, 4))
            {
                case "0000": hex.Append("0"); 
                    break;
                case "0001": hex.Append("1"); 
                    break;
                case "0010": hex.Append("2"); 
                    break;
                case "0011": hex.Append("3");
                    break;
                case "0100": hex.Append("4");
                    break;
                case "0101": hex.Append("5");
                    break;
                case "0110": hex.Append("6"); 
                    break;
                case "0111": hex.Append("7");
                    break;
                case "1000": hex.Append("8");
                    break;
                case "1001": hex.Append("9"); 
                    break;
                case "1010": hex.Append("A"); 
                    break;
                case "1011": hex.Append("B");
                    break;
                case "1100": hex.Append("C"); 
                    break;
                case "1101": hex.Append("D"); 
                    break;
                case "1110": hex.Append("E"); 
                    break;
                case "1111": hex.Append("F"); 
                    break;
            }
        }
        string result = hex.ToString();
        Console.WriteLine(result.TrimStart('0'));
        Console.WriteLine();
    }
}

