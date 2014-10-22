namespace BankSystem
{
    using System;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate)
        {
        }

        public decimal Withdraw(decimal balance, decimal withdrawAmount)
        {
            if (balance < withdrawAmount)
            {
                Console.WriteLine("This operation cannot be performed due to insufficient funds!!!");
            }

            return (decimal)balance - (decimal)withdrawAmount;
        }

        public override decimal CalculateInterestAmount(decimal periodInMonths)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return periodInMonths * 0;
            }

            return this.Balance * this.InterestRate * periodInMonths;
        }
    }
}
