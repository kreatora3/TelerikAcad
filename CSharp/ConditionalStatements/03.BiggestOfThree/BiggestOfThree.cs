/*Write a program that finds the biggest of three integers using nested if statements.*/

using System;



class BiggestOfThree
{
    static void Main()
    {

        int maxNum = int.MinValue;
        
        Console.Write("Enter number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter another one: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Last number I want you to enter: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Now I'll show you which one of the three entered is biggest one :)");
        Console.WriteLine();


        if (firstNum > maxNum)
        {
            maxNum = firstNum;

            if (secondNum > maxNum)
            {
                maxNum = secondNum;              
            }

            if (thirdNum > maxNum)
            {
                maxNum = thirdNum;
            }
        }

        Console.WriteLine("The biggest number is {0}", maxNum);
        Console.WriteLine();
    }
}

