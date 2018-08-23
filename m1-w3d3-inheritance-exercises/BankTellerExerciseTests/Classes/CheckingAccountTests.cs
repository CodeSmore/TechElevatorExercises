using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests.Classes
{
    [TestClass()]
    public class CheckingAccountTests
    {

        [TestMethod()]
        public void CheckingAccountTest()
        {
            CheckingAccount checkAccount = new CheckingAccount();
            Assert.AreEqual(0, checkAccount.Balance, "Balance is not 0 on creation. Dummy");

            checkAccount.Withdraw(10);
            Assert.AreEqual(-20, checkAccount.Balance, "Something wrong with CheckingAccount Withdrawal");

            checkAccount.Withdraw(10);
            Assert.AreEqual(-40, checkAccount.Balance, "Extra charge should be implemented each time balance is < 0 on withdrawal.");

            checkAccount.Withdraw(70);
            Assert.AreEqual(-40, checkAccount.Balance, "Withdrawals that leave bank account lower than -$100 should be ignored.");
        }
        
    }
}
