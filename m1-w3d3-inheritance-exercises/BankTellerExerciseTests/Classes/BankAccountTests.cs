using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void BankAccountTest()
        {
            BankAccount account = new BankAccount();
            BankAccount otherAccount = new BankAccount();

            Assert.AreEqual(0, account.Balance, "Constructor must set balance to zero.");

            account.Deposit(33);
            Assert.AreEqual(33, account.Balance, "Issue with the deposit, FIX IT");

            account.Transfer(otherAccount, 33);
            Assert.AreEqual(33, otherAccount.Balance, "Issue with transfer to account.");
            Assert.AreEqual(0, account.Balance, "issue with transfer from account");

            account.AccountNumber = "666Hahaha";
            Assert.AreEqual("666Hahaha", account.AccountNumber, "Issue setting or getting account number.");
        }
    }
}
