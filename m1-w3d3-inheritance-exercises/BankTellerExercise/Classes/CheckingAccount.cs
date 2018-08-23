using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (this.Balance - amountToWithdraw > -100)
            {
                base.Withdraw(amountToWithdraw);

                if (this.Balance < 0)
                {
                    // overdraft fee
                    base.Withdraw(10);
                }
            }

            return this.Balance;
        }
    }
}
