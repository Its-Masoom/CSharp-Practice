using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public interface IBankAccount
    {
        // Interface which makes classes necessary to implement its functions if classes are using it. 

        void Deposit(double cash);
        void Withdraw(double cash);
        void Deposit(string accountNumber, double cash);
        void Withdraw(string accountNumber, double cash);
    }
}