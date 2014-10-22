namespace BankSystem
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        
        public override decimal CalculateInterestAmount(decimal periodInMonths)
        {
            if (this.Customer is IndividualCustomer)
            {
                periodInMonths -= 6;

                if (periodInMonths < 0)
                {
                    periodInMonths = 0;
                }
            }

            if (this.Customer is Company)
            {
                if (periodInMonths <= 12)
                {
                    periodInMonths /= 2;
                }
                else
                {
                    periodInMonths -= 6;
                }
            }

            return this.Balance * this.InterestRate * periodInMonths;
        }
    }
}
