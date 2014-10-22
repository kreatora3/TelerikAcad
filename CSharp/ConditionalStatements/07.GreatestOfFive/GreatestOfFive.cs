/*Write a program that finds the greatest of given 5 variables.*/

using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double e = double.Parse(Console.ReadLine());
        Console.WriteLine();

        double greatestNumber = double.MinValue;

        if (a >= greatestNumber)
        {
            greatestNumber = a;
        }

        if (b >= greatestNumber)
        {
            greatestNumber = b;
        }

        if (c >= greatestNumber)
        {
            greatestNumber = c;
        }
        if (d >= greatestNumber)
        {
            greatestNumber = d;
        }
        if (e >= greatestNumber)
        {
            greatestNumber = e;
        }

        Console.WriteLine("The greatest number is {0}", greatestNumber);
        Console.WriteLine();
    }
}

