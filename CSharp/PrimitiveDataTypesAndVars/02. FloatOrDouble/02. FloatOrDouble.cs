/*Which of the following values can be assigned to a variable of type float and which to a variable of type double:
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
*/

using System;


class Program
{
    static void Main()
    {
        double num1 = 34.567839023;
        float num2 = 12.345f;
        float num3 = 8923.1234857f;
        float num4 = 3456.091f;

        Console.WriteLine("{0} is assigned as double. The rest numbers --> {1} , {2} , {3} could be floats.", num1, num2, num3, num4);
        Console.WriteLine();


    }
}

