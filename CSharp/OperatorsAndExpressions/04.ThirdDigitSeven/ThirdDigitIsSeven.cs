/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.*/


using System;


class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter a four digit or above number: ");
        string num = Console.ReadLine();
        char thirdDigit = num[num.Length - 3];

        int checkDigit = (int)Char.GetNumericValue(thirdDigit);



        if (checkDigit == 7)
        {
            Console.WriteLine("The third digit (right-to-left) of the number you have just entered is 7");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The third digit (right-to-left) of the number you have just entered is not 7");
            Console.WriteLine();
        }
    }
}

