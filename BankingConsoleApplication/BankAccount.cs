﻿// See https://aka.ms/new-console-template for more information

// Task 1: Setting Up the Account
public class BankAccount
{
    private string accountName;
    private int accountNumber;
    private decimal balance;

    public BankAccount(string name, int number, decimal initialDeposit)
    {
        accountName = name;
        accountNumber = number;
        balance = initialDeposit;
    }

    // Task 2: Implementing User Interactions
    public void RunBankingApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Deposit ");
            Console.WriteLine("2. Withdraw ");
            Console.WriteLine("3. View Balance ");
            Console.WriteLine("4. Exit ");
            Console.Write("Please select an option: ");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Write("\nEnter deposit amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Deposit(amount);
            }
            else if (userInput == "2")
            {
                Console.Write("\nEnter withdrawal amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Withdraw(amount);
            }
            else if (userInput == "3")
            {
                Console.WriteLine($"\nYour current balance is: ${GetBalance()}\n");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("\nExiting... Thank you for using our services!");
                isRunning = false;
            }
            else
            {
                Console.WriteLine("\nInvalid option, please try again.");
            }
        }
    }


    // Task 3: Recording Transactions

    private decimal[] transactionHistory = new decimal[10];
    private int transactionCount = 0;

    private void RecordTransaction(decimal amount)
    {
        if (transactionCount < transactionHistory.Length)
        {
            transactionHistory[transactionCount++] = amount;
        }
        else
        {
            Console.WriteLine("\nTransaction history is full. Oldest transactions will be overwritten.");
        }
    }

    // Task 4: Performing Calculations
    public void Deposit(decimal amount)
    {
        balance += amount;
        RecordTransaction(amount);
        Console.WriteLine("\nDeposit successful.\n");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            RecordTransaction(-amount);
            Console.WriteLine("\nWithdrawal successful.\n");
        }
        else
        {
            Console.WriteLine("\nInsufficient funds.\n");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

}