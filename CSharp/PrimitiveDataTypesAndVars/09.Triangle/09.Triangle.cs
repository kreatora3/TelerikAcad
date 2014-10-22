/*Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
 * Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
*/

using System;


class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char copyRightSymbol = '\u00A9';

        for (int i = 1; i < 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(copyRightSymbol);
            }
            Console.WriteLine();
            
                       
        }
        for (int x = 3; x > 0; x--)
        {
            for (int y = 0; y < x; y++)
            {
                Console.Write(copyRightSymbol);

            }
            Console.WriteLine();
        }

        Console.WriteLine();

    }
}

