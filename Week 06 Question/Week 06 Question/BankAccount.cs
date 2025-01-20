using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_Question
{
    internal class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        private static int accountcount = 0;

        public BankAccount (int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
            AccountHolder = accountHolder;        }
    }
}
