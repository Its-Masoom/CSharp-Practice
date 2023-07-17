using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public class Bank
    {
        // Dictionary to store BankAccount Information
        // Here String ---> Acount Number and BankAccount ---> BankAccount Object
        public Dictionary<string, BankAccount> BankAccounts { get; set; }

        // Constructor to initialize Bank

        public Bank()
        {
            BankAccounts = new Dictionary<string, BankAccount>();
        }
        public void AddAccount(BankAccount account)
        {
            BankAccounts.Add(account.get_acc_number(), account);
            Console.WriteLine($"Account {account.get_acc_number()} added to the bank.");
        }

        public void DepositToAccount(string accountNumber, double cash)
        {
            if (BankAccounts.ContainsKey(accountNumber))
            {
                BankAccount account = BankAccounts[accountNumber];
                account.Deposit(cash);
            }
            else
            {
                Console.WriteLine($"Account {accountNumber} not found.");
            }
        }
        public void WithdrawFromAccount(string accountNumber, double cash)
        {
            if (BankAccounts.ContainsKey(accountNumber))
            {
                BankAccount account = BankAccounts[accountNumber];
                account.Withdraw(cash);
            }
            else
            {
                Console.WriteLine($"Account {accountNumber} not found.");
            }
        }


    }
}
