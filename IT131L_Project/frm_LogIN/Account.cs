using System;
using System.Collections.Generic;

namespace frm_LogIN
{
    public class Account
    {
        string last_name, first_name, pin;
        double balance;
        int accountNumber;
        List<Transaction_History> transaction_history;

        // Thread-safe Singleton
        private static volatile Account instance = null;
        private static object syncRoot = new Object();

        public string Last_Name
        {
            get { return last_name; }
        }

        public string First_Name
        {
            get { return first_name; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string Pin
        {
            get { return pin; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public List<Transaction_History> Transaction_History
        {
            get { return transaction_history; }
            set { transaction_history = value; }
        }

        public Account(string last_name, string first_name, double balance, string pin, int accountNumber,
            List<Transaction_History> transaction_history)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.balance = balance;
            this.pin = pin;
            this.accountNumber = accountNumber;
            this.transaction_history = transaction_history;
        }

        // Singleton instantiation
        public static Account CreateInstance(string last_name, string first_name, double balance, string pin, int accountNumber,
            List<Transaction_History> transaction_history)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Account(last_name,first_name, balance, pin, accountNumber, transaction_history);
                }
            }
            else
            {
                instance.last_name = last_name;
                instance.first_name = first_name;
                instance.balance = balance;
                instance.pin = pin;
                instance.accountNumber = accountNumber;
                instance.transaction_history = transaction_history;
            }

            return instance;
        }

        public void WithdrawMoney(double withdrawAmount)
        {
            balance -= withdrawAmount;
            // Create Withdraw entry for Transaction_History
        }

        public void TransferFunds(double transferAmount, Account receiver)
        {
            balance -= transferAmount;
            // Create Transfer entry for Transaction_History

            receiver.Balance += transferAmount;
            // Create Receive entry for Transaction History
        }

        public void DepositMoney(double depositAmount)
        {
            balance += depositAmount;
            // Create a Deposit entry for Transaction_History
        }
    }
}
