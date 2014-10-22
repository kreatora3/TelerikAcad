/*You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class StringToSum
{
    static void Main()
    {
        string number = "23 23    23  454  646  4 666   7778  889  999";
        number = number.Trim();

        char[] separator = {' '};
        int sum = 0;
      
        string[] array = number.Split(separator, StringSplitOptions.RemoveEmptyEntries);  /* using StringSplitOptions helps us is white spaces
                                                                                           between numbers are more than one.Else while parsing 
                                                                                           out programe will crash*/            

        for (int i = 0; i < array.Length; i++)
        {
            
            sum += int.Parse(array[i]);
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}

