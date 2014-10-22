/*A marketing firm wants to keep record of its employees.
 * Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, 
 * unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
*/

using System;


class MarketingFirm
{
    static void Main()
    {
        Console.Write("Please enter the employee's first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Please enter the employee's last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Please enter the employee's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter the employee's gender m/f: ");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter the employee's ID number: ");
        int idNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Please enter the employee's unique number: ");
        int uniqeNum = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("First name: {0}  \nLast name: {1} \nAge: {2} years \nGenger: {3} \nID Number: {4} \nEmploye Unique Number: {5}", firstName, lastName, age, gender, idNum, uniqeNum);
        Console.WriteLine();
        Console.WriteLine();
         
    }
}

