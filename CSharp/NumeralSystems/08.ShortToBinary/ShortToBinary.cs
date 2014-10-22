/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ShortToBinary
{
    private static void NegativeConvert(short number)
    {
        short copy = number;
        short[] binary = new short[16];
        number *= -1;
        number -= 1;
        int i = 0;
        while (number > 0)
        {
            binary[i] = (short)(number % 2);
            number /= 2;
            i++;
        }

        Array.Reverse(binary);

        Console.Write("Binary representation of {0} is: ", copy);

        foreach (var member in binary)
        {
            if (member == 1)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("1");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    private static void PositiveConvert(short number)
    {
        short copy = number;
        List<short> binary = new List<short>();
        while (number > 0)
        {
            binary.Add((short)(number % 2));
            number /= 2;
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



    static void Main()
    {

        Console.Write("Enter number between (-32,768 to 32,767): ");

        short number = short.Parse(Console.ReadLine());

        Console.WriteLine();

        if (number > 0)
        {
            PositiveConvert(number);
        }
        else if (number == 0)
        {
            Console.WriteLine("0000");
            Console.WriteLine();
        }
        else
        {
            NegativeConvert(number);
        }

    }

}







