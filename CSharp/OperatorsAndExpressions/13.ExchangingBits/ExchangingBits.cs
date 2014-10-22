/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/


using System;



class ExchangingBits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
       

        uint firstMask = 7 << 3;              //creating mask for small 3 bits
        uint smallBits = number & firstMask;   // extracting small 3 digits

        uint secondMask = 7 << 24;             // creating mask for large 3 bits
        uint largeBits = number & secondMask;  //extracting large 3 digits.

        uint temporary = smallBits | largeBits;  // creating mask that holds ONLY both small and large bits on their positions.

        uint tripleZero = number ^ temporary; // creating number that has 000 on positions 3,4,5 and 24,25,26
       
        uint firstFill = tripleZero | (smallBits << 21);  // moving small bits to posiotions of large ones
        uint secondFill = firstFill | (largeBits >> 21);    // moving large bits to positions of small ones

        
        // this below is short version of above 4 lines of code.
        uint shortVersion = (number ^ (smallBits | largeBits)) | (smallBits << 21) | (largeBits >> 21);
        Console.WriteLine();
        Console.WriteLine("Decimal result {0}", shortVersion);

        Console.WriteLine();

        Console.WriteLine("The number you entered was {0} ({1})", Convert.ToString(number, 2).PadLeft(32, '0'), number);
        Console.WriteLine();
        Console.WriteLine("The number now is {0} ({1})", Convert.ToString(secondFill, 2).PadLeft(32, '0'), shortVersion);
        Console.WriteLine();
    }
}

        
        

        
        

        
        

        
        
        

        
        

        
        

        

