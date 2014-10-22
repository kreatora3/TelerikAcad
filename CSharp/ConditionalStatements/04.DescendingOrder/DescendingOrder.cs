/*Sort 3 real values in descending order using nested if statements.*/

using System;



class Program
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
        Console.WriteLine("Now I'll show you the numbers in descending order :)");
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

        if (maxNum == firstNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine(maxNum);
                Console.WriteLine(secondNum);
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(maxNum);
                Console.WriteLine(thirdNum);
                Console.WriteLine(secondNum);
            }            
                
        }
        if (maxNum == secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine(secondNum);
                Console.WriteLine(firstNum);
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(secondNum);
                Console.WriteLine(thirdNum);
                Console.WriteLine(firstNum);
            }
        }
        if (maxNum == thirdNum)
        {
            if (firstNum > secondNum)
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(firstNum);
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(secondNum);
                Console.WriteLine(firstNum);
            }
            
        }
        Console.WriteLine(); 

    }
}

