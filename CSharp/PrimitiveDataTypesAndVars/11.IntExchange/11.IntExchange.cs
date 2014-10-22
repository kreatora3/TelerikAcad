/*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
*/
using System;



class IntExchange
{
    static void Main()
    {
        Console.WriteLine("We have \"a\" integer with value of 5 and \"b\" integer with value of 10 and \nafter some coding ... ");
        Console.WriteLine();
        int a = 5;
        int b = 10;
        int c = b - a;
        b = b -c;
        a = a + c;
        Console.WriteLine("Int \"a\" is now {0} \nInt \"b\" is now {1}", a, b);
        Console.WriteLine();
        Console.Write("You can try it your self :). Please enter your first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Now enter second number: ");
        b = int.Parse(Console.ReadLine());

        int d = b - a;
        b = b-d;
        a = b + d;
        Console.WriteLine("The numbers you have entered now exchange their values so first number is now {0} and second is {1}", a, b);
        Console.WriteLine();

       
    }
}

