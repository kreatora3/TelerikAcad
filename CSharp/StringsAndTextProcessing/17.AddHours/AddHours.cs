/*Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

class AddHours
{
    static void Main()
    {
        Console.WriteLine("Enter date in the format day.month.year hour:minute:second: ");
        string input = Console.ReadLine();
        string format = "dd.MM.yyyy HH:mm:ss";
        DateTime dateHours = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
        dateHours = dateHours.AddHours(6.5);
        Console.WriteLine("{0}  {1}", dateHours.ToString("dddd", new CultureInfo("bg-BG")), dateHours.ToString("hh:mm:ss"), new CultureInfo("bg-BG"));
    }
}

