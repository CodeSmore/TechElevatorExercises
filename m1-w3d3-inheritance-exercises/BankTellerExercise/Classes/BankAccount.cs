using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountNumber
        {
            get;
            set;
        }

        public decimal Balance
        {
            get;
            private set;
        }

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;

            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;

            return Balance;
        }

        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            this.Withdraw(transferAmount);

            destinationAccount.Deposit(transferAmount);
        }

        public BankAccount()
        {
            Balance = 0;
        }
    }
}
