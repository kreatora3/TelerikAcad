/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
	Do the above in two different ways: with and without using quoted strings.
*/

using System;


    class TwoStrings
    {
        static void Main()
        {
            //First way using "\"
            string firstWay = "The \"use\" of quotations causes difficulties.";
            //second way using "@"
            string secondWay = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstWay);
            Console.WriteLine();
            Console.WriteLine(secondWay);
            Console.WriteLine();
        }
    }

