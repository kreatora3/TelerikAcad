/*Write a program that prints to the console which day of the week is today. Use System.DateTime.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DayOfTheWeek
{
    static void Main()
    {
        DateTime weekDayToday = DateTime.Now;

        Console.WriteLine("Today is {0}", weekDayToday.DayOfWeek);
        Console.WriteLine();
    }
}

