namespace Pr_02_BankOfCurtovoConare
{
    using System;
    using System.Collections.Generic;

    class TestBank
    {
        static void Main()
        {
            DepositAccount deposit = new DepositAccount("individual", 1500m, 5m);
            //Console.WriteLine(deposit.CalculateInterest(6));
            //deposit.WithdrawMoney(1600m);
            //deposit.WithdrawMoney(1000m);
            //deposit.DepositMoney(1500m);
            //Console.WriteLine(deposit.Balance);


            IAccount mortgage = new MortgageAccount("company", 1500m, 5m);
            Console.WriteLine(mortgage.CalculateInterest(18));
        }
    }
}
