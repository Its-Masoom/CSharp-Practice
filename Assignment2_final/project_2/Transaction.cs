﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public class Transaction
    {
        // Properties to store transaction details
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }

        // Constructor to initialize transaction details
        public Transaction(decimal amount, string type)
        {
            Date = DateTime.Now;
            Amount = amount;
            Type = type;
        }
    }

}