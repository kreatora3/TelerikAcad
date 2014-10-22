/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
 * such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */

using System;


class TwoPositiveInts
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int p = 0;
        if (firstNumber < secondNumber)                               //We make check if first number is smaller than second in order the for loop to work corectly.
        {
            for (int i = firstNumber; i <= secondNumber; i++)        /*For the numbers between first entered to the last we check if they divide by 5 without reminder.
                                                                     If so we add 1 to the p. In the end we get the number of ints that divided by 5 get reminder 0 :)*/
            {
                if (i % 5 == 0)
                p++;
            }
        }
        else
        {
            Console.WriteLine("Please enter second number to be greater than first number");
        }

        Console.WriteLine();
        Console.WriteLine(p);
        Console.WriteLine();
    }
}

