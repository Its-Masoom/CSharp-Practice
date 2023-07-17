using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public interface ITransaction
    {
        // Interface which makes classes necessary to implement its functions if classes are using it. 
        void ExecuteTransaction(decimal amount);
        void PrintTransaction();
    }
}