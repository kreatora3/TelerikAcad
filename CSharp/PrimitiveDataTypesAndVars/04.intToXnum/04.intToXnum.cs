/*Declare an integer variable and assign it with the value 254 in hexadecimal format. 
 * Use Windows Calculator to find its hexadecimal representation.
*/

using System;



    class intToXnum
    {
        static void Main()
        {
            // first solution
            int num1 = 254;
            string xnum1 = num1.ToString("x");
            Console.WriteLine("The hexadecimal representation of decimal number 254 is \'{0}\'", xnum1);
            Console.WriteLine();
           // second solution
            Console.WriteLine("This is the second solution using directly formatint string, so again the hexadecimal representation of decimal number 254 is \'{0:x}\'", num1);
            Console.WriteLine();
        }
    }

