using System;
using System.Collections.Generic;
using System.Text;

namespace BankingManagementSystem
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string accountNo;
        private string email;
        private int phoneNumber;

        public int CustomerId
        {
            get { return customerId; }
        }

        public string AccountNo
        {
            get { return accountNo; }
        }

        public Customer(int customerId, string customerName, string accountNo, string email, int phoneNumber)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.accountNo = accountNo;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
        }

        public void UpdateEmail(string email)
        {
            this.email = email;
        }

        public void UpdatePhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
