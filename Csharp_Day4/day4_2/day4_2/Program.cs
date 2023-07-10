using System;
using System.Collections.Generic;

public class BankAccount
{
    public string Acc_Number { get; set; }
    public string Acc_Holder_Name { get; set; }
    public int Balance { get; set; }

    public BankAccount(string acc_number, string acc_holder_name, int balance)
    {
        Acc_Number = acc_number;
        Acc_Holder_Name = acc_holder_name;
        Balance = balance;
    }

    public virtual void Deposit()
    {

    }

    public virtual void Withdraw()
    {

    }

    public void DisplayAccountInfo()
    {

    }
}

public class SavingsAccount: BankAccount
{
    public int interestRate { get; set; }
    public override void Deposit()
    {

    }

}

public class CheckingAccount  : BankAccount
{
    public override void Withdraw()
    {

    }
}

public class Bank
{
    public void AddAccount()
    {

    }

    public void DepositToAccount()
    {

    }
    public void WithdrawFromAccount()
    {

    }
}



class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        Bank bank = new Bank();

        SavingsAccount saving_account = new SavingsAccount();

        CheckingAccount checking_account = new CheckingAccount();
    }
}

