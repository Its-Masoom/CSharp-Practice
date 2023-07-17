using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public abstract class BankAccount : IBankAccount
    {
        private string Acc_Number;
        private string Acc_Holder_Name;
        private double Balance;
        public List<Transaction> Transactions { get; set; }


        public string get_acc_number()
        {
            return Acc_Number;
        }
        public string get_acc_holder_name()
        {
            return Acc_Holder_Name;
        }
        public double get_balance()
        {
            return Balance ;
        }

        public string set_acc_number(string accNumber)
        {
            return (Acc_Number = accNumber);
        }

        public string set_acc_holder_name(string holderName)
        {
            return (Acc_Holder_Name = holderName);
        }

        public double set_balance(double balance)
        {
            return Balance = balance;
        }


        public BankAccount(string acc_number, string acc_holder_name, double balance)
        {
            Acc_Number = acc_number;
            Acc_Holder_Name = acc_holder_name;
            Balance = balance;
            Transactions = new List<Transaction>();
        }

        public virtual void Deposit(double cash)
        {
            Balance = Balance + cash;
            Console.WriteLine($"Deposited Rs-{cash} into account {Acc_Number}. New balance: Rs-{Balance}");
            Transactions.Add(new Transaction((decimal)cash, "Deposit"));

        }

        public virtual void Withdraw(double cash)
        {
            if (cash <= Balance)
            {
                Balance = Balance - cash;
                Console.WriteLine($"Withdrawn Rs-{cash} from account {Acc_Number}. New balance: Rs-{Balance}");
                Transactions.Add(new Transaction((decimal)cash, "Withdraw"));

            }
            else
            {
                Console.WriteLine($"Insufficient cash in your account {Acc_Number}");
            }
        }
        public void Deposit(string accountNumber, double cash)
        {
            if (accountNumber == Acc_Number)
            {
                Deposit(cash);
            }
        }

        public void Withdraw(string accountNumber, double cash)
        {
            if (accountNumber == Acc_Number)
            {
                Withdraw(cash);
            }
        }

        public abstract void DisplayAccountInfo();
        public abstract void CalculateInterest(double cash);

    }
}
