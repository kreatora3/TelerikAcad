namespace BitArrayClass
{
    using System;

    public class BitTesting
    {
        public static void Main()
        {
            BitArray64 test = new BitArray64();

        test[12] = 1;
        test[44] = 1;
        test[2] = 1;
        Console.WriteLine(test);

        test[43] = 1;
        Console.WriteLine(test);

        test[63] = 1;
        Console.WriteLine(test);
        }
    }
}
