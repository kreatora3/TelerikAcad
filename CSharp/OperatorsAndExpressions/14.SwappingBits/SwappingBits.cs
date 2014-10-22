/** Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer*/
using System;




class SwappingBits
{
    static void Main()
    {
        int p, q, k;
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter the bit number p: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Enter the bit number q: ");
            q = int.Parse(Console.ReadLine());
            Console.Write("Enter the bit counter k: ");
            k = int.Parse(Console.ReadLine());
        }
        while ((p + k > 32) || (q + k > 32) || ((p < q) && (q < p + k)) || ((q < p) && (p < q + k)));

        int numberK = Convert.ToInt32(Math.Pow(2, k)) - 1; //calculating the number that will let us to extract the bits we search for swap
        int smallKBits = number & (numberK << p);  // extracting small bits
        int largeKBits = number & (numberK << q);  // extracting large bits
        int swappedBits = (number ^ (smallKBits | largeKBits)) | smallKBits << (q-p) | largeKBits >> (q-p); // creating temporary number then we put in large bits on the place of small and small on the place of large.
       
        
        Console.WriteLine();
        Console.WriteLine("The number you have entered is {0} ({1})", Convert.ToString(number, 2).PadLeft(32, '0'), number);
        Console.WriteLine();
        Console.WriteLine("The result after bits swap is {0} ({1})", Convert.ToString(swappedBits, 2).PadLeft(32,'0'), swappedBits);
    }
}

