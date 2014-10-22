/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.*/

using System;


class IntIsPrimeOrNot
{
    static void Main()
    {
        Console.Write("Enter number between 1 and 100: ");
        int number = int.Parse(Console.ReadLine());
        double sqrtOfNumber = Math.Sqrt(number);
        int integerNumber = (int)sqrtOfNumber;
        int devisor = 0;
       
        for (int i = 2; i <=integerNumber; i++)
        {

            if (number % i == 0)
                devisor++;
            
        }
        if (devisor != 0)
        {
            Console.WriteLine("The number is not prime");
        }
        else
        {
            Console.WriteLine("The number is prime");
        }
    }
}

