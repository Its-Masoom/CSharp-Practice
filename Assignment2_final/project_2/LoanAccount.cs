using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    // There is Dependance Relationship because LoanAccount is depending on ITransaction

    public class LoanAccount : BankAccount, ITransaction
    {
        public double LoanAmount { get; set; }

        // Constructor to initialize LoanAccount

        public LoanAccount(string acc_number, string acc_holder_name, double balance, double loan_amount)
            : base(acc_number, acc_holder_name, balance)
        {
            LoanAmount = loan_amount;
        }

        // Example of Polymorphism Overriding

        public override void Deposit(double cash)
        {
            set_balance(get_balance() + cash);
            Console.WriteLine($"Deposited Rs-{cash} into loan account {get_acc_number()}. New balance: Rs-{get_balance()}");
            Transactions.Add(new Transaction((decimal)cash, "Cash Deposit"));

        }

        // Example of Polymorphism Overriding

        public override void Withdraw(double cash)
        {
            if (cash <= get_balance())
            {
                set_balance(get_balance() - cash);
                Console.WriteLine($"Withdrawn Rs-{cash} from loan account {get_acc_number()}. New balance: Rs-{get_balance()}");
                Transactions.Add(new Transaction((decimal)cash, "Cash Withdrawn"));

            }
            else
            {
                Console.WriteLine($"Insufficient cash in your account {get_acc_number()}");
            }
        }

        // Example of Polymorphism Overriding

        public override void CalculateInterest(double cash)
        {
            Console.WriteLine("No interest calculation for loan account.");
        }
        public void ExecuteTransaction(decimal amount)
        {
            Console.WriteLine($"Loan executed: Amount received ----> {amount}");
            Deposit((double)amount);
        }

        public void PrintTransaction()
        {
            Console.WriteLine("Loan transaction executed");
            Console.WriteLine("Remaining Debt: Rs-{0}", LoanAmount - get_balance());

        }

        // Example of Polymorphism Overriding

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {get_acc_number()}");
            Console.WriteLine($"Account Holder Name: {get_acc_holder_name()}");
            Console.WriteLine($"Loan Amount Taken: {LoanAmount}");
            Console.WriteLine($"Current balance in Account: {get_balance()}");
            Console.WriteLine("Transaction History:");
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine($"Date: {transaction.Date}, Amount: {transaction.Amount}, Type: {transaction.Type}");
            }

        }
    }

}