/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AlphabeticOrder
{
    static void Main()
    {
        string text = "abc fnd sss wes pet met get fat wet smeas sega askda sjsa askeen assnee snastifg ";

        string[] list = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(list);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

