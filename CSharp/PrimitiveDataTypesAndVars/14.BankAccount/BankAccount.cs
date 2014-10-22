/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */



using System;


class BankAccount
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Jameson";
        string lastName = "Smith";
        decimal availableAmount = 26589.36m;
        string bankName = "Whatever Bank";
        object iban = "BG07FINV915010BGN0CH47";
        object bic = "FINVBGSF";
        ulong firstCreditCard = 5585320123456789;
        ulong secondCreditCard = 5698586963214576;
        ulong thirdCreditCard = 3698752145826982;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine();
        Console.WriteLine("Amount available: {0:c2}", availableAmount);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine();
        Console.WriteLine("First credit card: {0}", firstCreditCard);
        Console.WriteLine("Second credit card: {0}", secondCreditCard);
        Console.WriteLine("Third credit card: {0}", thirdCreditCard);
        Console.WriteLine();
    }
}

