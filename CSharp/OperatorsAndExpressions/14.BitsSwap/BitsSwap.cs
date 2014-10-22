using System;


class BitsSwap
{
    static void Main()
    {
        uint p, q, k;
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter the bit number p: ");
            p = uint.Parse(Console.ReadLine());
            Console.Write("Enter the bit number q: ");
            q = uint.Parse(Console.ReadLine());
            Console.Write("Enter the bit counter k: ");
            k = uint.Parse(Console.ReadLine());
        }
        while ((p + k > 32) || (q + k > 32) || ((p < q) && (q < p + k)) || ((q < p) && (p < q + k)));

        uint numberK = (uint)(Math.Pow(2, k)) - 1;
        uint firstKBits = number & (numberK << p);
        uint lastKBits = number & (numberK << q);
        uint swappedBits = (number ^ (firstKBits | lastKBits)) | (firstKBits << (q - p)) | (lastKBits >> (q - p));
      
        Console.WriteLine(swappedBits);
    }
}

