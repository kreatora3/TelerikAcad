/*Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

using System;

class SomeStringsAndObject
{
    static void Main()
    {
        string name1 = "Hello";
        string name2 = "World";
        object nameObject = (name1 + ' ' + name2);
        string name3 = (string)(nameObject);
        Console.WriteLine(name3);
        Console.WriteLine();
    }
}

