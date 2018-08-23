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
    public class SavingsAccountTests
    {

        [TestMethod()]
        public void SavingsAccountTest()
        {
            SavingsAccount saveAccount = new SavingsAccount();
            Assert.AreEqual(0, saveAccount.Balance, "Account Balance not set to 0 on creation");

            saveAccount.Deposit(200);
            Assert.AreEqual(200, saveAccount.Balance, "Account not depositing correctly");

            saveAccount.Withdraw(25);
            Assert.AreEqual(175, saveAccount.Balance, "Savings account withdrawal error");

            saveAccount.Withdraw(26);
            Assert.AreEqual(147, saveAccount.Balance, "Savings account withdrawal below $150 error");


        }
    }
}
