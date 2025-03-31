using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AdvancedProgrammingAssignment1
{
    internal abstract class Account
    {
        static public List<string> transactions = new List<string>();
        public string type { get; set; }
        static int IDCounter = 1;
        public int accountID { get; private set; }
        public double balance;
        public Customer customer;
        public Account(double Balance, Customer customer) 
        {
            accountID = IDCounter++;
            balance = Balance;
            this.customer = customer;
            customer.accounts.Add(this);
        }

        public string Deposit( double amount) 
        { 
            balance += amount;
            return $"{type} {accountID}; Deposit Amount: ${amount}; Transaction Status: Successful; Current Balance: {balance}";

        }

        public virtual string Withdraw(double amount) 
        {
            string transaction;
            if (balance >= amount ) { balance -= amount; transaction = "Successful"; }
            else {  transaction = "Failed"; }
            return $"{type} {accountID}; Withdrawal Attempt: ${amount}; Transaction Status: {transaction}; Current Balance: {balance}"; 
        }

        public virtual string DisplayInfo()
        {
            return $"{type} {accountID}; Current Balance: {balance}";
        }

        public override string ToString()
        {
            return this.type;
        }
        
    }
}
