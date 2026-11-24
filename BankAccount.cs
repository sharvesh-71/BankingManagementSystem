using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    public class BankAccount
    {
        private string accountHolderName;
        private DateTime dateOpened;
        protected string accountNo;
        protected decimal balance;
        protected bool isActive;
        protected List<Transaction> transactions;

        public string AccountNo
        {
            get
            {
                return accountNo;
            }
        }

        public BankAccount(string accountNo, string accountHolderName, decimal balance)
        {
            this.accountNo = accountNo;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            this.isActive = true;
            this.dateOpened = DateTime.Now;

            transactions = new List<Transaction>();

        }

        public string Deposit(decimal amount, bool recordTransaction = true)
        {
            if (!isActive)
            {
                return "Deposit failed as the account is inactive.";
            }

            if (amount <= 0)
            {
                return "Deposit failed, amount must be greater than zero.";
            }

            balance += amount;

            if (recordTransaction)
            {
                AddTransaction(amount, "Deposit", "Amount deposited to account.", null);
            }

            return $"Rs. {amount} successfully deposited to Ac. No. {accountNo}.";
        }

        public virtual string Withdraw(decimal amount, bool recordTransaction = true)
        {
            if (!isActive)
            {
                return "Withdrawal failed as the account is inactive.";
            }

            if (amount <= 0)
            {
                return "Withdrawal failed, amount must be greater than zero.";
            }

            if (amount <= balance)
            {
                balance -= amount;

                if (recordTransaction)
                {
                    AddTransaction(amount, "Withdrawal", "Amount withdrawn from account.", null);
                }

                return $"Rs. {amount} successfully withdrawn from Ac. No. {accountNo}.";
            }

            return "Withdrawal failed. The amount exceeds your balance.";
        }

        protected void AddTransaction(decimal amount, string type, string description, string relatedAccountNo)
        {
            Transaction transaction = new Transaction(transactions.Count + 1, amount, type, description, relatedAccountNo);
            transactions.Add(transaction);
        }

        public decimal CheckBalance()
        {
            return balance;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Account Holder: {accountHolderName}");
            Console.WriteLine($"Balance: Rs. {balance}");
            Console.WriteLine($"Date Opened: {dateOpened}");
            Console.WriteLine($"Account Status: {(isActive ? "Active" : "Inactive")}");
        }

        public string ActivateAccount()
        {
            if (isActive)
            {
                return "Account is already active.";
            }

            isActive = true;
            return "Account activated successfully.";
        }

        public string DeactivateAccount()
        {
            if (!isActive)
            {
                return "Account is already inactive.";
            }

            isActive = false;
            return "Account deactivated successfully.";

        }

        public string Transfer(BankAccount toAccount, decimal amount)
        {

            if (toAccount == null)
            {
                return "Transfer failed. Destination account does not exist.";
            }

            if (!toAccount.isActive)
            {
                return "Transfer failed as the destination account is inactive.";
            }

            if (amount <= 0)
            {
                return "Transfer failed, amount must be greater than zero.";
            }

            string withdrawResult = Withdraw(amount, false);

            if (withdrawResult.Contains("successfully"))
            {
                toAccount.Deposit(amount, false);

                Transaction senderTransaction = new Transaction(transactions.Count + 1, amount, "Transfer", "Money transferred.", toAccount.accountNo);
                transactions.Add(senderTransaction);

                Transaction receiverTransaction = new Transaction(toAccount.transactions.Count + 1, amount, "Transfer", "Money received.", accountNo);
                toAccount.transactions.Add(receiverTransaction);

                return $"Rs. {amount} transferred successfully.";
            }

            return "Transfer failed. " + withdrawResult;
        }

        public void DisplayTransactionHistory()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions found.");
                return;
            }

            foreach (Transaction transaction in transactions)
            {
                transaction.DisplayTransactionDetails();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
