using System.Collections.Generic;

namespace frm_LogIN
{
    public class Account
    {
        string last_name, first_name;
        double balance;
        int pin, accountNumber;
        List<Transaction_History> transaction_history;

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
