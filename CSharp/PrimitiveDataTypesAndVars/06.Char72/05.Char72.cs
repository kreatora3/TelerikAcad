/*Declare a character variable and assign it with the symbol that has Unicode code 72. 
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
*/

using System;

class Char72
{
    static void Main()
    {
        char symbol = '\u0048'; // number 72 in hex format is 48
        Console.WriteLine(symbol);
       
        // second solution
        char symbol2  = (char)72;
        Console.WriteLine(symbol2);
    }

}
