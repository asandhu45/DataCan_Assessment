using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCan_Assessment
{
    public class Account
    {
        /// <summary>
        /// Constructor to set the starting balance of the account
        /// </summary>
        /// <param name="bal">Starting balance</param>
        public Account(decimal bal)
        {
            Balance = bal;
        }

        //Account balance
        public decimal Balance { get; private set; }

        /// <summary>
        /// Decrease the entered amount out of the total balance
        /// </summary>
        /// <param name="amt"></param>
        public void Withdraw(decimal amt)
        {
            //If the balance is less than the amount withdrawn
            if (Balance < amt)
            {
                MessageBox.Show("Insufficient Funds");
            }
            //Dont' let the user withdraw 0$
            else if (amt == 0)
            {
                MessageBox.Show("Can't withdraw 0$");
            }
            else
            {
                Balance -= amt;
                MessageBox.Show("Amount Withdrawn!");
            }
        }

        /// <summary>
        /// Add the entered amount out of the total balance 
        /// </summary>
        /// <param name="amt">Amount entered</param>
        public void Deposit(decimal amt)
        {
            //Dont' let the user deposit 0$
            if (amt == 0)
            {
                MessageBox.Show("Can't deposit 0$");
            }
            else
            {
                Balance += amt;
                MessageBox.Show("Amount Deposited!");
            }
        }

    }
}
