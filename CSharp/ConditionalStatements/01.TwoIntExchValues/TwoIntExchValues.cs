/*Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
*/

using System;


class TwoIntExchValues
{
    static void Main()
    {
        int someNumber;
        int firstNumber;
        int secondNumber;

        do
        {
            Console.WriteLine("Please make sure that first number is greater than second");
            Console.WriteLine();
            Console.Write("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        while (firstNumber < secondNumber);
        
        
        if (firstNumber > secondNumber)
        {
            someNumber = firstNumber - secondNumber;
            firstNumber = secondNumber;
            secondNumber = firstNumber + someNumber;
            Console.WriteLine("First number after swap is now {0}", firstNumber);
            Console.WriteLine("Second number after swap is now {0}", secondNumber);
            Console.WriteLine();
        }

    }
}

