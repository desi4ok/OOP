using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_BankOfCurtovoConare
{
    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(string customer, decimal balance, decimal rate) : base(customer, balance, rate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;

            if (base.Customer == "individual" && months > 3)
            {
                interest = base.Balance * (1 + base.InterestRate / 100 * (months - 3)) - base.Balance;
            }
            else if (base.Customer == "company" && months > 2)
            {
                interest = base.Balance * (1 + base.InterestRate / 100 * (months - 2)) - base.Balance;
            }
            return interest;
        }
    }
}
