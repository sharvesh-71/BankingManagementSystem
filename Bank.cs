using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    public class Bank
    {
        private string bankName;
        private string branchName;
        private string branchCode;
        private List<Customer> customers;
        private List<BankAccount> accounts;

        public Bank(string bankName, string branchName, string branchCode)
        {
            this.bankName = bankName;
            this.branchName = branchName;
            this.branchCode = branchCode;

            customers = new List<Customer>();
            accounts = new List<BankAccount>();
        }

        public string AddCustomer(int customerId, string customerName, string accountNo, string email, int phoneNumber)
        {
            Customer customer = new Customer(customerId, customerName, accountNo, email, phoneNumber);
            customers.Add(customer);

            return "New customer added successfully.";
        }

        public Customer? FindCustomer(int customerId)
        {
            foreach (Customer customer in customers)
            {
                if (customer.CustomerId == customerId)
                {
                    return customer;
                }
            }

            return null;
        }

        public string AddSavingsAccount(string accountNo, string accountHolderName, decimal balance, decimal interestRate)
        {
            SavingsAccount account = new SavingsAccount(accountNo, accountHolderName, balance, interestRate);

            accounts.Add(account);

            return "Savings account created successfully.";
        }

        public string AddCurrentAccount(string accountNo, string accountHolderName, decimal balance, decimal overdraftLimit)
        {
            CurrentAccount account = new CurrentAccount(accountNo, accountHolderName, balance, overdraftLimit);

            accounts.Add(account);

            return "Current account created successfully.";
        }

        public BankAccount? FindAccount(string accountNo)
        {
            foreach (BankAccount account in accounts)
            {
                if (account.AccountNo == accountNo)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
