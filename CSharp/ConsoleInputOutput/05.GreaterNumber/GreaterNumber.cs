/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.*/

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter second numer: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number of both you entered is {0}", greaterNumber);
        Console.WriteLine();
    }
}


