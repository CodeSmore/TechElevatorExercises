using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private List<BankAccount> accountsList = new List<BankAccount>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVIP
        {
            get
            {
                decimal totalBalance = 0;

                foreach (BankAccount account in Accounts)
                {
                    totalBalance += account.Balance;
                }

                if (totalBalance >= 25000M)
                {
                    return true;
                }
                return false;
            }
        }
        public BankAccount[] Accounts
        {
            get
            {
                return accountsList.ToArray();
            }
        }

        public void AddAccount(BankAccount newAccount)
        {
            accountsList.Add(newAccount);
        }
    }
}
