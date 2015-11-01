namespace Pr_02_BankOfCurtovoConare
{
    using System;

    public abstract class Account : IAccount
    {
        private string customer;
        private decimal balance;
        private decimal interestRate;

        public Account(string customer, decimal balance, decimal rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = rate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be 0!");
                }
                this.balance = value;
            }
        }

        public string Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer cannot be null or empty");
                }

                if (value == "individual" || value == "company")
                {
                    this.customer = value;
                }
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Interest Rate has to be between 0 and 100");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal a = Balance * (1 + InterestRate/ 100 * months);
            return a;
        }

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
        }
    }
}
