/*Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000.
*/

using System;


class FiveVariables
{
    static void Main()
    {
        ushort num1 = 52130;
        sbyte num2 = -115;
        int num3 = 4825932;
        byte num4 = 97;
        short num5 = -10000;
        Console.WriteLine ("{0} is ushort , \n{1} is sbyte, \n{2} is int, \n{3} is byte, \n{4} is short", num1, num2, num3, num4, num5);
    }
}

