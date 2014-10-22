/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 Display them in the standard date format for Canada.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


class DateExtract
{
    static void Main(string[] args)
    {
        string format = "dd.MM.yyyy";

        string text = "today is 21.01.2014 and tomorrow will be 22.01.2014 and whatever";

        foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
        {

            string extractedToString = Convert.ToString(extracted);

            DateTime date = DateTime.ParseExact(extractedToString, format, CultureInfo.InvariantCulture);

            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
 
    }
}

