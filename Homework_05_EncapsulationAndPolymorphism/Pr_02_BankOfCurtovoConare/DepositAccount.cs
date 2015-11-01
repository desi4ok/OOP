using System;

namespace Pr_02_BankOfCurtovoConare
{
    public class DepositAccount : Account, IAccount, IWithdrawable
    {
        public DepositAccount(string customer, decimal balance, decimal rate) : base(customer, balance, rate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;

            if (Balance > 1000)
            {
                interest = base.Balance * (1 + base.InterestRate/ 100 * months) - base.Balance;
            }
            return interest;
        }

        public void WithdrawMoney(decimal amount)
        {
            decimal balanceAfterWithdraw = Balance - amount;

            if (balanceAfterWithdraw < 0)
            {
                throw new ArgumentOutOfRangeException("Not enough balance in your account!");
            }
            else
            {
                Balance = balanceAfterWithdraw;
            }
        }
    }
}
