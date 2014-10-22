/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console.*/

using System;


class CompanyManager
{
    static void Main()
    {
        Console.Write("Enter company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter the address of the company: ");
        string address = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter website: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string managerFirst = Console.ReadLine();
        Console.Write("Enter manager's second name: ");
        string managerSecond = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        string age = Console.ReadLine();
        Console.Write("Enter manager's phone: " );
        string managerPhone = Console.ReadLine();
    }
}

