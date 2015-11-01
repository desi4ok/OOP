namespace Pr_02_BankOfCurtovoConare
{
    public class MortgageAccount : Account, IAccount
    {
        public MortgageAccount(string customer, decimal balance, decimal rate) : base(customer, balance, rate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;

            if (base.Customer == "individual" && months > 6)
            {
                interest = base.Balance * (1 + base.InterestRate / 100 * (months - 6)) - base.Balance;
            }
            else if (base.Customer == "company" && months > 12)
            {
                interest = (base.Balance * (1 + base.InterestRate / 100 * 12) - base.Balance) / 2;
                interest += (base.Balance * (1 + base.InterestRate / 100 * (months - 12))) - base.Balance;
            }
            return interest;
        }
    }
}
