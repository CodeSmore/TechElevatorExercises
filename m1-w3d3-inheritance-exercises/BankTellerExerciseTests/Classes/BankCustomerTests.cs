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
    public class BankCustomerTests
    {
        [TestMethod()]
        public void BankCustomerTest()
        {
            BankCustomer newCustomer = new BankCustomer();
            newCustomer.Name = "Lucy";
            newCustomer.PhoneNumber = "(555)333-2018";
            newCustomer.Address = "McDonalds Dumpster";

            // test properties of BankCustomer
            Assert.AreEqual("Lucy", newCustomer.Name, "Name is messed up.");
            Assert.AreEqual("(555)333-2018", newCustomer.PhoneNumber, "PhoneNumber is messed up.");
            Assert.AreEqual("McDonalds Dumpster", newCustomer.Address, "Address is messed up.");


            CheckingAccount newChecking = new CheckingAccount();
            Assert.AreEqual(300, newChecking.Deposit(300), "Issue w/ checking deposit");
            newChecking.AccountNumber = "1";

            newCustomer.AddAccount(newChecking);

            Assert.AreEqual(300, newCustomer.Accounts[0].Balance, "Customer account balance issue");

            // test added accounts!!! WOOOOO!!!

            SavingsAccount newSavings = new SavingsAccount();
            newCustomer.AddAccount(newSavings);

            newCustomer.Accounts[1].Deposit(50);
            newCustomer.Accounts[1].Withdraw(10);

            Assert.AreEqual(38, newCustomer.Accounts[1].Balance, "Issue with BankCustomer's savings account");

            // VIP tests
            newCustomer.Accounts[0].Deposit(20000);
            newCustomer.Accounts[1].Deposit(5000);

            Assert.AreEqual(true, newCustomer.IsVIP, "IsVIP is being applied to a customer whom is not a VIP");

            newCustomer.Accounts[0].Withdraw(20000);
            Assert.AreEqual(false, newCustomer.IsVIP, "IsVIP is counting something as VIP that shouldn't be");

        }
    }
}
