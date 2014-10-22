//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;


class ReadThreeInts
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();
        Console.Write("Enter third number: ");
        string thirdNumber = Console.ReadLine();

        Console.WriteLine("The first number you have entered is {0}, the second one is {1} and the last was {2}", firstNumber, secondNumber, thirdNumber);
    }
}

