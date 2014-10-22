/*Create a program that assigns null values to an integer and to double variables. 
 * Try to print them on the console, try to add some values or the null literal to them and see the result.
*/

using System;


class NullValues
{
    static void Main()
    {
        int? newInt = null;
        double? newDouble = null;

        Console.WriteLine("This is nullable integer  with value of {0}", newInt );  //prints text, not value
        newInt = 5;
        Console.WriteLine("This is nullable integer  with value of {0}", newInt); //prints text, value is now 5
        Console.WriteLine();
        Console.WriteLine("This is \'double?\' with value of {0}", newDouble); //prints text, not value
        newDouble = 3.5;
        Console.WriteLine("This is \'double?\' with value of {0}", newDouble); //prints text, value is now 3,5


        int regularInt = 35;
        double regularDouble = 3.5;

        //int sum = regularInt + newInt;   // error, due to that "int?" could not be placed in "int"
        //Console.WriteLine(sum);
        Console.WriteLine();
        int sum2 = regularInt + newInt.GetValueOrDefault(); //prints 40
        Console.WriteLine("Now using \'GetValueOrDefault()\' we can  sum both \'int?\' and \'int\'  in new \'int\'  and the result is {0}", sum2);
        Console.WriteLine();

        

      
    }
}


