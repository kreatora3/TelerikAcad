/*Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/

using System;


class DividedByFiveAndSeven
{
    static void Main()
    {
        Console.Write("Please enter a number ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number can be divided by 7 and 5 at the same time without reminder");
        }
        else
        {
            Console.WriteLine("The number cannot be divided by 7 and 5 without reminder");
        }
        
    }
}

