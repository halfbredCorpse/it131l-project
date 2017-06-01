using System.Collections.Generic;

namespace Class_Account
{
    public class Account
    {
        string last_name, first_name;
        double balance;
        int pin, accountNumber;
        List<Transaction_History> transaction_history;

        public string Last_Name
        {
            get { return last_name;  }
        }

        public string First_Name
        {
            get { return first_name; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public int Pin
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

        public Account(string last_name, string first_name, double balance, int pin, int accountNumber,
            List<Transaction_History> transaction_history) 
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.balance = balance;
            this.pin = pin;
            this.accountNumber = accountNumber;
            this.transaction_history = transaction_history;
        }
    }
}
