using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingAssignment1
{
    internal class OmniAccount : Account
    {
        public double interestRate;
        public double failedTransactionFee;
        public double overdraftLimit;
        public OmniAccount(double Balance, Customer customer, double InterestRate, double FailedTransactionFee, double OverdraftLimit) : base(Balance, customer)
        {
            type = "Omni";
            interestRate = InterestRate;
            failedTransactionFee = FailedTransactionFee;
            failedTransactionFee-= failedTransactionFee*customer.staffDiscount;
            overdraftLimit = OverdraftLimit-OverdraftLimit*customer.staffDiscount;
        }

        public string CalculateInterest()
        {
            if (balance < 1000) { return ""; }
            balance += balance * interestRate / 100;
            return $"{type} {accountID}; Current Balance: {balance}";

        }

        public override string Withdraw(double amount)
        {
            string transaction;
            if (balance < amount)
            {
                balance = Math.Max(balance - failedTransactionFee, 0);
                transaction = "Failed";
            }

            else { balance = Math.Max(balance - amount, 0); transaction = "Successful"; }

            return $"{type} {accountID}; Withdrawal Attempt: ${amount}; Transaction Status: {transaction}; Failed Transaction Fee: ${failedTransactionFee} Updated Balance: {balance}";
        }
        public override string DisplayInfo() { return $"{type} {accountID}; Interest Rate: {interestRate}%; Overdraft Limit: ${overdraftLimit}; Fee: ${failedTransactionFee}; Current Balance: {balance};"; }
    }
}
