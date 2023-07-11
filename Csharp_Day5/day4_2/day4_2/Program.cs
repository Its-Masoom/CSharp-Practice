using System;
using System.Collections.Generic;

public interface IBankAccount
{
    void Deposit(double cash);
    void Withdraw(double cash);
}

public abstract class BankAccount : IBankAccount
{
    protected string Acc_Number { get; set; }
    protected string Acc_Holder_Name { get; set; }
    protected double Balance { get; set; }

    public string get_acc_number()
        {
            return Acc_Number;
        }

    public BankAccount(string acc_number, string acc_holder_name, double balance)
    {
        Acc_Number = acc_number;
        Acc_Holder_Name = acc_holder_name;
        Balance = balance;
    }

    public virtual void Deposit(double cash)
    {
        Balance = Balance + cash;
        Console.WriteLine($"Deposited Rs-{cash} into account {Acc_Number}. New balance: Rs-{Balance}");

    }

    public virtual void Withdraw(double cash)
    {
        if (cash <= Balance)
        {
            Balance = Balance - cash;
            Console.WriteLine($"Withdrawn Rs-{cash} from account {Acc_Number}. New balance: Rs-{Balance}");
        }
        else
        {
            Console.WriteLine($"Insufficient cash in your account {Acc_Number}");
        }
    }

    //public void DisplayAccountInfo()
    //{
    //    Console.WriteLine($"Account Number: {Acc_Number}");
    //    Console.WriteLine($"Account Holder Name: {Acc_Holder_Name}");
    //    Console.WriteLine($"Balance: {Balance}");
    //}
    public abstract void DisplayAccountInfo();
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string acc_number, string acc_holder_name, double balance, double interestrate)
        : base(acc_number, acc_holder_name, balance)
    {
        InterestRate = interestrate;
    }
    public override void Deposit(double cash)
    {
        double interest_cash = cash * InterestRate;
        Balance = Balance + cash + interest_cash;
        Console.WriteLine($"Deposited Rs-{cash} into account {Acc_Number} with interest. New balance: Rs-{Balance}");
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {Acc_Number}");
        Console.WriteLine($"Account Holder Name: {Acc_Holder_Name}");
        Console.WriteLine($"Balance: {Balance}");
    }

}

public class CheckingAccount : BankAccount, IBankAccount
{
    public CheckingAccount(string acc_number, string acc_holder_name, double balance)
    : base(acc_number, acc_holder_name, balance)
    {
    }
    public override void Withdraw(double cash)
    {
        if (cash <= Balance)
        {
            Balance = Balance - cash;
            Console.WriteLine($"Withdrawn Rs-{cash} from account {Acc_Number}. New balance: Rs-{Balance}");
        }
        else
        {
            Console.WriteLine($"Insufficient cash in your account {Acc_Number}");
        }
    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {Acc_Number}");
        Console.WriteLine($"Account Holder Name: {Acc_Holder_Name}");
        Console.WriteLine($"Balance: {Balance}");
    }
}

public class Bank
{

    public List<BankAccount> bank_acc_list { get; set; }

    public Bank()
    {
        bank_acc_list = new List<BankAccount>();
    }
    public void AddAccount(BankAccount account)
    {
        bank_acc_list.Add(account);
        Console.WriteLine($"Account {account.get_acc_number()} added to the bank.");
    }

    public void DepositToAccount(string account_number, double cash)
    {
        BankAccount account = null;
        foreach (BankAccount acc in bank_acc_list)
        {
            if (acc.get_acc_number() == account_number)
            {
                account = acc;
                break;
            }
        }

        if (account != null)
        {
            account.Deposit(cash);
        }
        else
        {
            Console.WriteLine($"Account {account_number} not found.");
        }

    }
    public void WithdrawFromAccount(string account_number, double cash)
    {
        BankAccount account = null;
        foreach (BankAccount acc in bank_acc_list)
        {
            if (acc.get_acc_number() == account_number)
            {
                account = acc;
                break;
            }
        }
        if (account != null)
        {
            account.Withdraw(cash);
        }
        else
        {
            Console.WriteLine($"Account {account_number} not found.");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        SavingsAccount savings_account = new SavingsAccount("ABC-1234", "Muhammad Masoom", 50000, 0.10);

        CheckingAccount checking_account = new CheckingAccount("XYZ-4567", "Ali Hassan", 20000);

        bank.AddAccount(savings_account);
        bank.AddAccount(checking_account);

        bank.DepositToAccount("ABC-1234", 500);
        bank.WithdrawFromAccount("XYZ-4567", 1000);
        bank.WithdrawFromAccount("ABC-1234", 2000);

        savings_account.DisplayAccountInfo();
        checking_account.DisplayAccountInfo();

        Console.ReadLine();
    }
}