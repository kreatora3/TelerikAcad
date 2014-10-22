/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
  Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2004
Distance: 4 days

 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DayDistance
{
    static void Main()
    {

        try
        {
            string format = "d.MM.yyyy";
            Console.Write("Enter date in format - dd.mm.yyyy: ");
            string firstDate = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Enter date in format - dd.mm.yyyy: ");
            string secondDate = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);
            Console.WriteLine();

            
            Console.WriteLine((dateTwo - dateOne).TotalDays);
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid date format.Try again");
            Console.WriteLine();
        }
        
    }
}

