# Banking Management System

A console-based Banking Management System developed using **C#** to implement and practise Object-Oriented Programming (OOP) concepts through a practical banking application.

## Overview

The application simulates basic banking operations by allowing users to manage customers, create different types of bank accounts, perform financial transactions, and maintain transaction histories.

It uses inheritance and polymorphism to implement different account types, while encapsulation helps manage account and customer information.

## Features

- **Customer Management**
  - Add new customers.
  - Search for customers using their customer ID.
  - Update customer email and phone number.

- **Account Management**
  - Create Savings Accounts.
  - Create Current Accounts.
  - Search for accounts using account numbers.
  - Display account details.
  - Activate and deactivate accounts.

- **Banking Operations**
  - Deposit money.
  - Withdraw money.
  - Transfer money between accounts.
  - Check account balance.

- **Account-Specific Features**
  - Calculate and add interest to Savings Accounts.
  - Support overdraft facilities in Current Accounts.

- **Transaction Management**
  - Maintain transaction history for each account.
  - Record deposits, withdrawals, and transfers.
  - Display transaction details, including amount, date, type, and related account number.

## Technologies Used

- C#
- .NET
- Visual Studio

## OOP Concepts Implemented

- **Encapsulation:** Protecting account and customer data using access modifiers and controlled access through methods and properties.
- **Inheritance:** `SavingsAccount` and `CurrentAccount` inherit from the `BankAccount` class.
- **Polymorphism:** Method overriding is used to implement account-specific withdrawal behaviour.
- **Abstraction:** Common account operations and behaviour are organized within the base `BankAccount` class.

## Project Structure

```text
BankingManagementSystem/
│
├── Program.cs
├── Bank.cs
├── BankAccount.cs
├── SavingsAccount.cs
├── CurrentAccount.cs
├── Customer.cs
├── Transaction.cs
│
├── BankingManagementSystem.csproj
├── README.md
└── .gitignore
```

## How to Run

1. Clone this repository:

   ```bash
   git clone https://github.com/YOUR_USERNAME/BankingManagementSystem.git
   ```

2. Navigate to the project directory:

   ```bash
   cd BankingManagementSystem
   ```

3. Open the project in Visual Studio.

4. Build and run the application using Visual Studio, or execute:

   ```bash
   dotnet run
   ```

## Future Enhancements

- Add persistent data storage using a database.
- Implement input validation and exception handling.
- Add duplicate customer and account number checks.
- Improve transaction management and reporting.
- Introduce unit testing.

## Purpose

This project was developed as a hands-on learning exercise to strengthen C# programming skills and understand how OOP principles can be applied when building a real-world application.
