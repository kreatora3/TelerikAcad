/*Write a program that safely compares floating-point numbers with precision of 0.000001.
 * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
*/

using System;


class FloatCompare
{
    static void Main()
    {
        float num1 = 5.00000001f;
        float num2 = 5.00000003f;
        bool b = Math.Abs(num1 - num2) < 0.000001f;
        Console.WriteLine(b);


    }

}
