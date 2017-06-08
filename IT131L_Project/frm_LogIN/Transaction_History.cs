<<<<<<< HEAD
﻿namespace frm_LogIN
{
    public class Transaction_History
    {
        string date_time, transaction_type;
        int amount, transaction_number;

        public string Date_Time
        {
            get { return date_time; }
        }

        public string Transaction_type
        {
            get { return transaction_type; }
        }

        public int Amount
        {
            get { return amount; }
        }

        public int Transaction_Number
        {
            get { return transaction_number; }
        }

        public Transaction_History(string date_time, string transaction_type, int amount, int transaction_number)
        {
            this.date_time = date_time;
            this.transaction_type = transaction_type;
            this.amount = amount;
            this.transaction_number = transaction_number;
        }
    }
}
=======
﻿namespace frm_LogIN
{
    public class Transaction_History
    {
        string date_time, transaction_type;
        int amount, transaction_number;

        public string Date_Time
        {
            get { return date_time; }
        }

        public string Transaction_type
        {
            get { return transaction_type; }
        }

        public int Amount
        {
            get { return amount; }
        }

        public int Transaction_Number
        {
            get { return transaction_number; }
        }

        public Transaction_History(string date_time, string transaction_type, int amount, int transaction_number)
        {
            this.date_time = date_time;
            this.transaction_type = transaction_type;
            this.amount = amount;
            this.transaction_number = transaction_number;
        }
    }
}
>>>>>>> master
