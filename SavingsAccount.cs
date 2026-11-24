using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate;

        public SavingsAccount(string accountNo, string accountHolderName, decimal balance, decimal interestRate) : base(accountNo, accountHolderName, balance)
        {
            this.interestRate = interestRate;
        }
        public decimal CalculateInterest()
        {
            decimal interest = CheckBalance() * interestRate / 100;
            return interest;
        }

        public string AddInterest()
        {
            decimal interest = CalculateInterest();
            Deposit(interest);

            return $"Interest of Rs. {interest} added successfully.";
        }

    }
}
