/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.
*/

using System;


class UserChoiceInput
{
    static void Main()
    {
        Console.Write("Type 1 for int, 2 for double, 3 for string : ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1: Console.Write("Enter int value: ");
                int newInt = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("You entered int as variable and now I'll add +1 to it. Result is {0}", newInt + 1);
                Console.WriteLine();
                break;

            case 2: Console.Write("Enter double value: ");
                double newDouble = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("You entered double as variable and now I'll add +1 to it. Result is {0}", newDouble + 1);
                Console.WriteLine();
                break;

            case 3: Console.Write("Enter some text: ");
                string newString = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("You entered some text (hence string) and now I'll add \"*\" to its end. Watch out --> {0}", newString + "*");
                Console.WriteLine();
                break;
           
            default: Console.WriteLine("Please choose 1, 2 or 3");
                Console.WriteLine();
                break;
        }
        Console.WriteLine();
    }

}
