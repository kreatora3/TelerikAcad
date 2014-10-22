namespace BankSystem
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(decimal periodInMonths)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (periodInMonths > 3)
                {
                    periodInMonths -= 3;
                }
                else
                {
                    periodInMonths = 0;
                }
            }

            if (this.Customer is Company)
            {
                if (periodInMonths > 2)
                {
                    periodInMonths -= 2;
                }
                else
                {
                    periodInMonths = 0;
                }
            }

            return this.Balance * this.InterestRate * periodInMonths;
        }
    }
}
