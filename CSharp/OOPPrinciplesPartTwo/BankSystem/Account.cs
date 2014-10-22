namespace BankSystem
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestMonthlyRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestMonthlyRate = interestRate / 100;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestMonthlyRate; }
            set { this.interestMonthlyRate = value / 100; }
        }

        public decimal DepositToAcc(decimal amounnt)
        {
            this.balance += (decimal)amounnt;
            return this.balance;
        }

        public abstract decimal CalculateInterestAmount(decimal periodInMonths);
    }
}
