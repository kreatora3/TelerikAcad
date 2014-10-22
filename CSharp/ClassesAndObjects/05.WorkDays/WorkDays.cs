/*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


class WorkDays
{
    static int WorkDaysLeft(DateTime date) 
    {
        DateTime[] holidays = 
        {
            new DateTime(2014, 03, 03),
            new DateTime(2014, 04, 18),
            new DateTime(2014, 05, 01),
            new DateTime(2014, 05, 02),
            new DateTime(2014, 05, 05),
            new DateTime(2014, 05, 06),
            new DateTime(2014, 09, 22),
            new DateTime(2014, 12, 24),
            new DateTime(2014, 12, 25),
            new DateTime(2014, 12, 26),
            new DateTime(2014, 12, 31),
            //new DateTime(2014, 01, 13)     //put your date to see if it works properly by extracting working days that are not Sun or Sat

        };

       
        DateTime currentDay = DateTime.Today;
        int timeLenght = (date - currentDay).Days;
        int counter = timeLenght+1;
       
        for (int i = 0; i <= timeLenght; i++)           
        {
            currentDay = currentDay.AddDays(i);

            if (currentDay.DayOfWeek == DayOfWeek.Sunday || currentDay.DayOfWeek == DayOfWeek.Saturday)
            {
                counter--;
            }
            for (int j = 0; j < holidays.Length ; j++)
            {
                if (currentDay == holidays[j])
                {
                    counter--;
                }
            }
            currentDay = DateTime.Today;
        }
        
        return counter;
    
    }

    static void Main()
    {
        
        Console.Write("Enter date (yyyy/mm/dd) format:  ");
        string toDate = Console.ReadLine();
        DateTime date = DateTime.Parse(toDate);
       
        Console.WriteLine(date);
        Console.WriteLine(WorkDaysLeft(date)); 
    }
}

