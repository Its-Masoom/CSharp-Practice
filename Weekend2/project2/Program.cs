using System;
using System.Collections.Generic;
namespace Bank_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("****************** Starting BankAccount Management System *******************");
            //    Console.WriteLine("\n");

            //    Bank bank = new Bank();

            //    SavingsAccount savings_account = new SavingsAccount("ABC-1234", "Muhammad Masoom", 50000, 0.10);
            //    CheckingAccount checking_account = new CheckingAccount("XYZ-4567", "Ali Hassan", 20000);
            //    LoanAccount loan_account = new LoanAccount("LMN-0101", "Faizan Rashid", 35000, 75000);

            //    bank.AddAccount(savings_account);
            //    bank.AddAccount(checking_account);
            //    bank.AddAccount(loan_account);

            //    Console.WriteLine(".............................................................................");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("********Depositing to Accounts********");
            //    Console.WriteLine("\n");
            //    bank.DepositToAccount("ABC-1234", 500);
            //    bank.DepositToAccount("XYZ-4567", 500);
            //    bank.DepositToAccount("LMN-0101", 500);


            //    Console.WriteLine(".............................................................................");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("********Withdrawing from Accounts********");
            //    Console.WriteLine("\n");
            //    bank.WithdrawFromAccount("ABC-1234", 2000);
            //    bank.WithdrawFromAccount("XYZ-4567", 1000);
            //    bank.WithdrawFromAccount("LMN-0101", 500);

            //    Console.WriteLine(".............................................................................");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("********Displaying all Accounts Information********");
            //    Console.WriteLine("\n");
            //    savings_account.DisplayAccountInfo();
            //    Console.WriteLine("**************************************");
            //    checking_account.DisplayAccountInfo();
            //    Console.WriteLine("**************************************");
            //    loan_account.DisplayAccountInfo();

            //    Console.WriteLine(".............................................................................");
            //    Console.WriteLine("\n");
            //    Console.WriteLine("********Loan Account Depositing Behaviour********");
            //    Console.WriteLine("\n");
            //    loan_account.ExecuteTransaction(12000);
            //    loan_account.PrintTransaction();


            //    Console.ReadLine();
            Console.WriteLine(".............................................");
            Console.WriteLine("Welcome to the Bank Account Management System!");
            Console.WriteLine(".............................................");

            Bank bank = new Bank();
            bool continueProgram = true;
            while (continueProgram)
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Check account balance");
                Console.WriteLine("5. View Transaction History");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Code for creating a new account
                        Console.WriteLine("************************");
                        Console.WriteLine("Enter account number: e.g. ABC123 or PK456");
                        string accountNumber = Console.ReadLine();
                        Console.WriteLine("Enter account holder name:");
                        string accountHolderName = Console.ReadLine();
                        Console.WriteLine("Enter initial balance:");
                        double initialBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("************************");


                        Console.WriteLine("Select account type:");
                        Console.WriteLine("1. Savings Account");
                        Console.WriteLine("2. Checking Account");
                        Console.WriteLine("3. Loan Account");
                        Console.Write("Enter type: ");
                        int accountTypeChoice = int.Parse(Console.ReadLine());

                        BankAccount newAccount;
                        if (accountTypeChoice == 1)
                        {
                            Console.WriteLine("Enter interest rate: (e.g. 0.1 for 10%)");
                            double interestRate = double.Parse(Console.ReadLine());
                            Console.WriteLine("*********************************************************");
                            newAccount = new SavingsAccount(accountNumber, accountHolderName, initialBalance, interestRate);

                        }
                        else if (accountTypeChoice == 2)
                        {
                            Console.WriteLine("*********************************************************");
                            newAccount = new CheckingAccount(accountNumber, accountHolderName, initialBalance);

                        }
                        else if (accountTypeChoice == 3)
                        {
                            Console.WriteLine("Enter loan amount:");
                            double loanAmount = double.Parse(Console.ReadLine());
                            Console.WriteLine("*********************************************************");
                            newAccount = new LoanAccount(accountNumber, accountHolderName, initialBalance, loanAmount);

                        }
                        else
                        {
                            Console.WriteLine("Invalid account type.");
                            continue;
                        }

                        bank.AddAccount(newAccount);
                        Console.WriteLine($"New account created with account number: {accountNumber}");
                        Console.WriteLine("*********************************************************");

                        break;

                    case 2:
                        // Code for depositing money
                        Console.WriteLine("Depositing money...");
                        Console.WriteLine("Enter account number:");
                        string depositAccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter amount to deposit:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        bank.DepositToAccount(depositAccountNumber, depositAmount);
                        Console.WriteLine("Money deposited successfully.");
                        Console.WriteLine("***************************************************************");

                        break;


                    case 3:
                        // Code for withdrawing money
                        Console.WriteLine("Withdrawing money...");
                        Console.WriteLine("Enter account number:");
                        string withdrawAccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter amount to withdraw:");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        bank.WithdrawFromAccount(withdrawAccountNumber, withdrawAmount);
                        Console.WriteLine("Money withdrawn successfully.");
                        Console.WriteLine("***************************************************************");

                        break;


                    case 4:
                        // Code for checking account balance
                        Console.WriteLine("Checking account balance...");
                        Console.WriteLine("Enter account number:");
                        string acc_Number = Console.ReadLine();

                        // Find the corresponding account based on the account number
                        if (bank.BankAccounts.ContainsKey(acc_Number))
                        {
                            BankAccount account = bank.BankAccounts[acc_Number];
                            Console.WriteLine("***************************************************************");
                            Console.WriteLine($"Account Number: {acc_Number}");
                            Console.WriteLine($"Balance: {account.get_balance()}");
                            Console.WriteLine("***************************************************************");

                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 5:
                        // Code for viewing transaction history
                        Console.WriteLine("Viewing transaction history...");
                        Console.WriteLine("Enter account number:");
                        string a_Number = Console.ReadLine();

                        // Find the corresponding account based on the account number
                        if (bank.BankAccounts.ContainsKey(a_Number))
                        {
                            BankAccount account = bank.BankAccounts[a_Number];
                            Console.WriteLine($"Account Number: {a_Number}");
                            Console.WriteLine("Transaction History:");
                            Console.WriteLine("***************************************************************");
                            foreach (Transaction transaction in account.Transactions)
                            {
                                Console.WriteLine($"Date: {transaction.Date}, Amount: {transaction.Amount}, Type: {transaction.Type}");
                            }
                            Console.WriteLine("***************************************************************");

                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 6:
                        // Code for exiting the application
                        Console.WriteLine("Exiting the application...");
                        // Add your code here
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                if (continueProgram)
                {
                    Console.WriteLine("Would you like to continue? (Y/N)");
                    string continueChoice = Console.ReadLine();
                    if (continueChoice.ToLower() != "y")
                    {
                        continueProgram = false;
                    }
                }

            }
        }
    }
}