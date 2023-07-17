using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public interface ITransaction
    {
        void ExecuteTransaction(decimal amount);
        void PrintTransaction();
    }
}
