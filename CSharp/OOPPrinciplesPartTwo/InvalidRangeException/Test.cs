namespace InvalidRangeException
{
    using System;
    using System.Globalization;

    public class Test
    {
        public static void Main()
        {
            int startInt = 1;
            int endInt = 100;

            int pointInInt;
            Console.WriteLine("Enter Point in int from 1 to 100");

            try
            {
                pointInInt = int.Parse(Console.ReadLine());
                if ((pointInInt < startInt) || (pointInInt > endInt))
                {
                    throw new InvalidRangeException<int>("Please, make sure you are in described range", startInt, endInt);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("Range should be [ {0}...{1} ]!", e.Start, e.End);
                Console.WriteLine(e.Message);
            }

            DateTime startDate = new DateTime(1880, 01, 01);
            DateTime endDate = DateTime.Now;

            DateTime dateTime;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter a date in range 1.1.1880 -[current moment] - use this format dd/mm/yyyy ");

            try
            {
                dateTime = DateTime.ParseExact(Console.ReadLine(), "d", culture);
                if ((dateTime < startDate) || (dateTime > endDate))
                {
                    throw new InvalidRangeException<DateTime>("Please, make sure you are in described range", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("Range should be [ {0}...{1} ]!", e.Start, e.End);
                Console.WriteLine(e.Message);
            }
        }
    }
}
