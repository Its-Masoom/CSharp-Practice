using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    // There is Dependance Relationship because SavingsAccount is depending on ITransaction
    public class SavingsAccount : BankAccount, ITransaction
    {
        public double InterestRate { get; set; }

        // Constructor to initialize SavingsAccount

        public SavingsAccount(string acc_number, string acc_holder_name, double balance, double interestrate)
            : base(acc_number, acc_holder_name, balance)
        {
            InterestRate = interestrate;
        }

        // Example of Polymorphism Overriding
        public override void Deposit(double cash)
        {
            double interest_cash = cash * InterestRate;
            set_balance(get_balance() + cash + interest_cash);
            Console.WriteLine($"Deposited Rs-{cash} into saving account {get_acc_number()} with interest Rs-{interest_cash}. New balance: Rs-{get_balance()}");
            Transactions.Add(new Transaction((decimal)cash, "Deposit with Interest"));

        }
        // Example of Polymorphism Overriding

        public override void CalculateInterest(double cash)
        {
            double calculate_interest = cash * InterestRate;
        }

        // Example of Polymorphism Overriding

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {get_acc_number()}");
            Console.WriteLine($"Account Holder Name: {get_acc_holder_name()}");
            Console.WriteLine($"Balance: {get_balance()}");
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine($"Date: {transaction.Date}, Amount: {transaction.Amount}, Type: {transaction.Type}");
            }
        }

        // Example of Polymorphism Overriding

        public override void Withdraw(double cash)
        {
            if (cash <= get_balance())
            {
                set_balance(get_balance() - cash);
                Console.WriteLine($"Withdrawn Rs-{cash} from saving account {get_acc_number()}. New balance: Rs-{get_balance()}");
                Transactions.Add(new Transaction((decimal)cash, "Cash Withdrawn"));

            }
            else
            {
                Console.WriteLine($"Insufficient cash in your account {get_acc_number()}");
            }
        }

        public void ExecuteTransaction(decimal amount)
        {
            Deposit((double)amount);
        }

        public void PrintTransaction()
        {
            Console.WriteLine($"Transaction executed: Deposit of Rs-{InterestRate * 100}% interest");
        }


    }
}
