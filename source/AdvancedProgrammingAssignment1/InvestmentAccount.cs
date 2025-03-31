using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AdvancedProgrammingAssignment1
{
    internal class InvestmentAccount : Account
    {
        public double interestRate;
        public double failedTransactionFee;

        public InvestmentAccount(double Balance, Customer customer, double interestRate, double failedTransactionFee):base(Balance, customer)
        {
            type = "Investment";
            this.interestRate = interestRate;
            this.failedTransactionFee = failedTransactionFee - failedTransactionFee * customer.staffDiscount;
        }

        public string CalculateInterest()
        {
            balance += balance * interestRate / 100;
            return $"{type} {accountID}; Current Balance: {balance}";
        }

        public override string Withdraw(double amount)
        {
            string transaction;
            if(balance < amount)
            {
                balance = Math.Max(balance-failedTransactionFee, 0);
                transaction = "Failed";
            }
            
            else { balance = Math.Max(balance - amount, 0); transaction = "Successful"; }

            return $"{type} {accountID}; Withdrawal Attempt: ${amount}; Transaction Status: {transaction}; Failed Transaction Fee: ${failedTransactionFee} Updated Balance: {balance}";
        }

        public override string DisplayInfo() { return $"{type} {accountID}; Interest Rate: {interestRate}%; Fee: ${failedTransactionFee}; Current Balance: {balance}"; }
    }
}
