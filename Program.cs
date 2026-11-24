using System;

namespace BankingManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool shouldExit = false;

            Bank bank = new Bank("ABC Bank", "Main Branch", "ABC001");

            while (!shouldExit)
            {
                Console.WriteLine("========== BANKING MANAGEMENT SYSTEM ==========");
                Console.WriteLine();
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Find Customer");
                Console.WriteLine("3. Create Savings Account");
                Console.WriteLine("4. Create Current Account");
                Console.WriteLine("5. Find Account");
                Console.WriteLine("6. Deposit Money");
                Console.WriteLine("7. Withdraw Money");
                Console.WriteLine("8. Transfer Money");
                Console.WriteLine("9. Check Balance");
                Console.WriteLine("10. Display Account Details");
                Console.WriteLine("11. Display Transaction History");
                Console.WriteLine("12. Activate Account");
                Console.WriteLine("13. Deactivate Account");
                Console.WriteLine("14. Update Customer Email");
                Console.WriteLine("15. Update Customer Phone Number");
                Console.WriteLine("16. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customer ID: ");
                        int customerId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter customer name: ");
                        string customerName = Console.ReadLine();

                        Console.Write("Enter account number: ");
                        string accountNo = Console.ReadLine();

                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();

                        Console.Write("Enter phone number: ");
                        int phoneNumber = Convert.ToInt32(Console.ReadLine());

                        string customerResult = bank.AddCustomer(customerId, customerName, accountNo, email, phoneNumber);

                        Console.WriteLine(customerResult);
                        break;

                    case 2:
                        Console.Write("Enter customer ID: ");
                        int searchCustomerId = Convert.ToInt32(Console.ReadLine());

                        Customer customer = bank.FindCustomer(searchCustomerId);

                        if (customer != null)
                        {
                            customer.DisplayCustomerDetails();
                        }
                        else
                        {
                            Console.WriteLine("Customer not found.");
                        }

                        break;

                    case 3:
                        Console.Write("Enter account number: ");
                        string savingsAccountNo = Console.ReadLine();

                        Console.Write("Enter account holder name: ");
                        string savingsAccountHolderName = Console.ReadLine();

                        Console.Write("Enter initial balance: ");
                        decimal savingsBalance = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter interest rate: ");
                        decimal interestRate = Convert.ToDecimal(Console.ReadLine());

                        string savingsResult = bank.AddSavingsAccount(savingsAccountNo, savingsAccountHolderName, savingsBalance, interestRate);

                        Console.WriteLine(savingsResult);
                        break;

                    case 4:
                        Console.Write("Enter account number: ");
                        string currentAccountNo = Console.ReadLine();

                        Console.Write("Enter account holder name: ");
                        string currentAccountHolderName = Console.ReadLine();

                        Console.Write("Enter initial balance: ");
                        decimal currentBalance = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter overdraft limit: ");
                        decimal overdraftLimit = Convert.ToDecimal(Console.ReadLine());

                        string currentResult = bank.AddCurrentAccount(currentAccountNo, currentAccountHolderName, currentBalance, overdraftLimit);

                        Console.WriteLine(currentResult);
                        break;

                    case 5:
                        Console.Write("Enter account number: ");
                        string searchAccountNo = Console.ReadLine();

                        BankAccount account = bank.FindAccount(searchAccountNo);

                        if (account != null)
                        {
                            Console.WriteLine("Account found.");
                            account.DisplayAccountDetails();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 6:
                        Console.Write("Enter account number: ");
                        string depositAccountNo = Console.ReadLine();

                        BankAccount depositAccount = bank.FindAccount(depositAccountNo);

                        if (depositAccount != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

                            string depositResult = depositAccount.Deposit(depositAmount);

                            Console.WriteLine(depositResult);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 7:
                        Console.Write("Enter account number: ");
                        string withdrawAccountNo = Console.ReadLine();

                        BankAccount withdrawAccount = bank.FindAccount(withdrawAccountNo);

                        if (withdrawAccount != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                            string withdrawResult = withdrawAccount.Withdraw(withdrawAmount);

                            Console.WriteLine(withdrawResult);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 8:
                        Console.Write("Enter source account number: ");
                        string sourceAccountNo = Console.ReadLine();

                        BankAccount sourceAccount = bank.FindAccount(sourceAccountNo);

                        if (sourceAccount == null)
                        {
                            Console.WriteLine("Source account not found.");
                            break;
                        }

                        Console.Write("Enter destination account number: ");
                        string destinationAccountNo = Console.ReadLine();

                        BankAccount destinationAccount = bank.FindAccount(destinationAccountNo);

                        if (destinationAccount == null)
                        {
                            Console.WriteLine("Destination account not found.");
                            break;
                        }

                        Console.Write("Enter amount to transfer: ");
                        decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

                        string transferResult = sourceAccount.Transfer(destinationAccount, transferAmount);

                        Console.WriteLine(transferResult);
                        break;

                    case 9:
                        Console.Write("Enter account number: ");
                        string balanceAccountNo = Console.ReadLine();

                        BankAccount balanceAccount = bank.FindAccount(balanceAccountNo);

                        if (balanceAccount != null)
                        {
                            Console.WriteLine($"Current Balance: Rs. {balanceAccount.CheckBalance()}");
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 10:
                        Console.Write("Enter account number: ");
                        string detailsAccountNo = Console.ReadLine();

                        BankAccount detailsAccount = bank.FindAccount(detailsAccountNo);

                        if (detailsAccount != null)
                        {
                            detailsAccount.DisplayAccountDetails();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 11:
                        Console.Write("Enter account number: ");
                        string historyAccountNo = Console.ReadLine();

                        BankAccount historyAccount = bank.FindAccount(historyAccountNo);

                        if (historyAccount != null)
                        {
                            historyAccount.DisplayTransactionHistory();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 12:
                        Console.Write("Enter account number: ");
                        string activateAccountNo = Console.ReadLine();

                        BankAccount activateAccount = bank.FindAccount(activateAccountNo);

                        if (activateAccount != null)
                        {
                            string activateResult = activateAccount.ActivateAccount();

                            Console.WriteLine(activateResult);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 13:
                        Console.Write("Enter account number: ");
                        string deactivateAccountNo = Console.ReadLine();

                        BankAccount deactivateAccount = bank.FindAccount(deactivateAccountNo);

                        if (deactivateAccount != null)
                        {
                            string deactivateResult = deactivateAccount.DeactivateAccount();

                            Console.WriteLine(deactivateResult);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }

                        break;

                    case 14:
                        Console.Write("Enter customer ID: ");
                        int emailCustomerId = Convert.ToInt32(Console.ReadLine());

                        Customer emailCustomer = bank.FindCustomer(emailCustomerId);

                        if (emailCustomer != null)
                        {
                            Console.Write("Enter new email: ");
                            string newEmail = Console.ReadLine();

                            emailCustomer.UpdateEmail(newEmail);

                            Console.WriteLine("Customer email updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Customer not found.");
                        }

                        break;

                    case 15:
                        Console.Write("Enter customer ID: ");
                        int phoneCustomerId = Convert.ToInt32(Console.ReadLine());

                        Customer phoneCustomer = bank.FindCustomer(phoneCustomerId);

                        if (phoneCustomer != null)
                        {
                            Console.Write("Enter new phone number: ");
                            int newPhoneNumber = Convert.ToInt32(Console.ReadLine());

                            phoneCustomer.UpdatePhoneNumber(newPhoneNumber);

                            Console.WriteLine("Customer phone number updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Customer not found.");
                        }

                        break;

                    case 16:
                        shouldExit = true;
                        Console.WriteLine("Thank you for using the Banking Management System.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}