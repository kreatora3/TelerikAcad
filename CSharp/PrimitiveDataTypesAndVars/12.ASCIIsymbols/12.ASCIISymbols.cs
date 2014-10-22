/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program 
 * that prints the entire ASCII table of characters on the console.
*/

using System;


class ASCIISymbols
{
    static void Main()
    {
       

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

