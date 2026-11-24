using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    public class CurrentAccount : BankAccount
    {
        private decimal overdraftLimit;
        public CurrentAccount(string accountNo, string accountHolderName, decimal balance, decimal overdraftLimit) : base(accountNo, accountHolderName, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override string Withdraw(decimal amount, bool recordTransaction = true)
        {
            string returnMessage;

            if (!isActive)
            {
                return "Withdrawal failed as the account is inactive.";
            }

            if (amount <= 0)
            {
                return "Withdrawal failed, amount must be greater than zero.";
            }

            bool usingOverdraft = false;

            if (amount > balance && amount <= balance + overdraftLimit)
            {
                balance -= amount;
                usingOverdraft = true;
                returnMessage = $"Rs. {amount} successfully withdrawn from Ac. No. {accountNo}. Overdraft amount was used, your balance is negative.";
            }

            else if (amount <= balance)
            {
                balance -= amount;
                returnMessage = $"Rs. {amount} successfully withdrawn from Ac. No. {accountNo}.";
            }

            else
            { 
                return "Withdrawal failed. Amount exceeds your balance and overdraft limit.";
            }

            if (recordTransaction)
            {
                if (usingOverdraft)
                {
                    AddTransaction(amount, "Withdrawal", "Withdrawal using overdraft facility.", null);
                }
                else
                {
                    AddTransaction(amount, "Withdrawal", "Normal withdrawal.", null);
                }
            }

            return returnMessage;
        }
    }
}
