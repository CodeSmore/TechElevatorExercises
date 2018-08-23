using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (this.Balance - amountToWithdraw > 0)
            {
                if (this.Balance - amountToWithdraw < 150)
                {
                    amountToWithdraw += 2;
                }

                base.Withdraw(amountToWithdraw);
            }
            

            return amountToWithdraw;
        }
    }
}
