namespace BankSystem
{
    using System;

    public class SystemTest
    {
        public static void Main()
        {
            IndividualCustomer pesho = new IndividualCustomer("Pesho");
            Company firma = new Company("Firma");

            LoanAccount indLoan = new LoanAccount(pesho, 100, 2);
            LoanAccount comLoan = new LoanAccount(firma, 200, 1);

            Console.WriteLine(indLoan.DepositToAcc(100));  // 100 + 100
            Console.WriteLine(indLoan.CalculateInterestAmount(12));
            Console.WriteLine();

            Console.WriteLine(comLoan.DepositToAcc(22)); // 200+22
            Console.WriteLine(comLoan.CalculateInterestAmount(12));
            Console.WriteLine();

            MortgageAccount indMort = new MortgageAccount(pesho, 200, 2);
            MortgageAccount comMort = new MortgageAccount(firma, 2000, 3);

            Console.WriteLine(indMort.CalculateInterestAmount(2));
            Console.WriteLine(comMort.CalculateInterestAmount(1));
            Console.WriteLine();

            DepositAccount indDep = new DepositAccount(pesho, 999, 1);
            DepositAccount comDep = new DepositAccount(firma, 12111, 3);

            Console.WriteLine(indDep.CalculateInterestAmount(12));
            Console.WriteLine(comDep.CalculateInterestAmount(11));
            Console.WriteLine();
        }
    }
}
