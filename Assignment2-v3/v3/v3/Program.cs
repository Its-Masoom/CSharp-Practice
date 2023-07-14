using System;
using System.Collections.Generic;

public interface IBankAccount
{
    void Deposit(double cash);
    void Withdraw(double cash);
}

public interface ITransaction
{
    void ExecuteTransaction(decimal amount);
    void PrintTransaction();
}

public abstract class BankAccount : IBankAccount
{
    private string Acc_Number;
    //{ get; set; }
    private string Acc_Holder_Name;
    //{ get; set; }
    private double Balance;
    //{ get; set; }

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
        return Balance;
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

    public abstract void DisplayAccountInfo();
}

public class SavingsAccount : BankAccount, ITransaction
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
        set_balance(get_balance() + cash + interest_cash);
        Console.WriteLine($"Deposited Rs-{cash} into saving account {get_acc_number()} with interest. New balance: Rs-{get_balance()}");
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {get_acc_number()}");
        Console.WriteLine($"Account Holder Name: {get_acc_holder_name()}");
        Console.WriteLine($"Balance: {get_balance()}");
    }

    public override void Withdraw(double cash)
    {
        if (cash <= get_balance())
        {
            set_balance(get_balance() - cash);
            Console.WriteLine($"Withdrawn Rs-{cash} from saving account {get_acc_number()}. New balance: Rs-{get_balance()}");
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

public class CheckingAccount : BankAccount, IBankAccount, ITransaction
{
    public CheckingAccount(string acc_number, string acc_holder_name, double balance)
    : base(acc_number, acc_holder_name, balance)
    {
    }
    public override void Withdraw(double cash)
    {
        if (cash <= get_balance())
        {
            set_balance(get_balance() - cash);
            Console.WriteLine($"Withdrawn Rs-{cash} from checking account {get_acc_number()}. New balance: Rs-{get_balance()}");
        }
        else
        {
            Console.WriteLine($"Insufficient cash in your account {get_acc_number()}");
        }
    }
    public override void Deposit(double cash)
    {
        set_balance(get_balance() + cash);
        Console.WriteLine($"Deposited Rs-{cash} into checking account {get_acc_number()}. New balance: Rs-{get_balance()}");

    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {get_acc_number()}");
        Console.WriteLine($"Account Holder Name: {get_acc_holder_name()}");
        Console.WriteLine($"Balance: {get_balance()}");
    }

    public void ExecuteTransaction(decimal amount)
    {
        Deposit((double)amount);
    }

    public void PrintTransaction()
    {
        Console.WriteLine("Transaction executed: Deposit");
    }
}

public class LoanAccount : BankAccount, ITransaction
{
    public double LoanAmount { get; set; }

    public LoanAccount(string acc_number, string acc_holder_name, double balance, double loan_amount)
        : base(acc_number, acc_holder_name, balance)
    {
        LoanAmount = loan_amount;
    }
    public override void Deposit(double cash)
    {
        set_balance(get_balance() + cash);
        Console.WriteLine($"Deposited Rs-{cash} into loan account {get_acc_number()}. New balance: Rs-{get_balance()}");

    }
    public override void Withdraw(double cash)
    {
            Console.WriteLine("You are not allowed to withdraw from your loan account. You can only deposit");
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

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {get_acc_number()}");
        Console.WriteLine($"Account Holder Name: {get_acc_holder_name()}");
        Console.WriteLine($"Loan Amount Taken: {LoanAmount}");
        Console.WriteLine($"Current balance in Account: {get_balance()}");

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
        Console.WriteLine("****************** Starting BankAccount Management System *******************");
        Console.WriteLine("\n");

        Bank bank = new Bank();

        SavingsAccount savings_account = new SavingsAccount("ABC-1234", "Muhammad Masoom", 50000, 0.10);
        CheckingAccount checking_account = new CheckingAccount("XYZ-4567", "Ali Hassan", 20000);
        LoanAccount loan_account = new LoanAccount("LMN-0101", "Faizan Rashid", 35000, 75000 );

        bank.AddAccount(savings_account);
        bank.AddAccount(checking_account);
        bank.AddAccount(loan_account);

        Console.WriteLine(".............................................................................");
        Console.WriteLine("\n");
        Console.WriteLine("********Depositing to Accounts********");
        Console.WriteLine("\n");
        bank.DepositToAccount("ABC-1234", 500);
        bank.DepositToAccount("XYZ-4567", 500);
        bank.DepositToAccount("LMN-0101", 500);


        Console.WriteLine(".............................................................................");
        Console.WriteLine("\n");
        Console.WriteLine("********Withdrawing from Accounts********");
        Console.WriteLine("\n");
        bank.WithdrawFromAccount("ABC-1234", 2000);
        bank.WithdrawFromAccount("XYZ-4567", 1000);
        bank.WithdrawFromAccount("LMN-0101", 500);

        Console.WriteLine(".............................................................................");
        Console.WriteLine("\n");
        Console.WriteLine("********Displaying all Accounts Information********");
        Console.WriteLine("\n");
        savings_account.DisplayAccountInfo();
        Console.WriteLine("**************************************");
        checking_account.DisplayAccountInfo();
        Console.WriteLine("**************************************");
        loan_account.DisplayAccountInfo();

        Console.WriteLine(".............................................................................");
        Console.WriteLine("\n");
        Console.WriteLine("********Loan Account Depositing Behaviour********");
        Console.WriteLine("\n");

        loan_account.ExecuteTransaction(12000);
        loan_account.PrintTransaction();

        Console.ReadLine();
    }
}