﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionPackage
{
    public class TransactionList
    {
        public static int MAX = 100; //MAX is static, don't need an object
        
        private List<Transaction> transactions;
        private int numTransactions;

        //constructor,
        //1) no return type
        //2) name same as the class
        public TransactionList()
        {
            transactions = new List<Transaction>();
        }

        //constructor
        public TransactionList(int num)
        {
            transactions = new List<Transaction>();
        }

        //operation
        public void Init(int size) { transactions = new List<Transaction>(); }

        public void Add(Transaction transaction) // add an object to an array
        {
            transactions.Add(transaction);
        }

        public void Display()
        {
            for (int i = 0; i < numTransactions; i++) //for loop
            {
                Console.WriteLine(transactions[i].ToString());
            }
        }
    }
}
