/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year to show you whether it is leap or not: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine(DateTime.IsLeapYear(year));
        Console.WriteLine();
    }
}

