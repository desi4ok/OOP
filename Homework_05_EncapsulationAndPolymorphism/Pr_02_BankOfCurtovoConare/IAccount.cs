namespace Pr_02_BankOfCurtovoConare
{
    public interface IAccount
    {
        string Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        void DepositMoney(decimal amount);

        decimal CalculateInterest(int months);
    }
}
