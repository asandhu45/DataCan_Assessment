//Amanjot Sandhu
//DataCan Assessment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCan_Assessment
{
    public partial class Form1 : Form
    {
        //Account object
        Account acc = null;

        //Hardcoded starting account balance
        const decimal balance = 1000;
        
        //Currency Dictionary - Contains all the different currencies and conversion rates
        Dictionary<string, decimal> Currencies = new Dictionary<string, decimal>()
        {
            { "CAD",  1.00m  },
            { "USD",  0.50m  },
            { "MXN",  10.00m },
            { "EURO", 0.25m  }
        };
        public Form1()
        {
            InitializeComponent();
            //Currency & account number starting selection
            currencyDropdown.SelectedIndex = 0;
            AccountNum_DropDown.SelectedIndex = 0;
            //Create new account object with the starting balance
            acc = new Account(balance);
            //Update the total balance textbox
            UpdateUI();
        }

        /// <summary>
        /// Click event for deposit button 
        /// Deposits the converted amount to the total balance 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depositButton_Click(object sender, EventArgs e)
        {
            //Amount to be deposited to the account
            decimal amount = amountNumericUpDown.Value;
            try
            {
                acc.Deposit(ConvertCurrency(currencyDropdown.Text, amount));
                UpdateUI();
            }
            catch (Exception ex)
            {
                //If an error exists show the error message then close the app
                MessageBox.Show(ex.Message);
                Close();
            }
        }
        /// <summary>
        /// Click event for deposit button 
        /// Withdraws the converted amount to the total balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //Amount to be withdrawn to the account
            decimal amount = amountNumericUpDown.Value;
            try
            {
                acc.Withdraw(ConvertCurrency(currencyDropdown.Text, amount));
                UpdateUI();
            }
            catch (Exception ex)
            {
                //If an error exists show the error message then close the app
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        /// <summary>
        /// Resets the account information to the starting balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Set the balance property to 1000
            acc.Balance = 1000;
            //Select CAD as the conversion currency again
            currencyDropdown.SelectedIndex = 0;
            UpdateUI(); 
        }

        /// <summary>
        /// Update the balance textbox and clear the NumericUpDown amount
        /// </summary>
        public void UpdateUI()
        {
            balanceTexbox.Text = "$" + acc.Balance.ToString();
            amountNumericUpDown.Value = 0;
        }

        /// <summary>
        /// Converts the specified amount from a foreign currency to CAD based on the current exchange rate.
        /// Seperate Class for currency conversion could be made like Account based on its complexity
        /// </summary>
        /// <param name="currency">Selected conversion currency</param>
        /// <param name="amt">Amount entered to be deposited or withdrawn</param>
        /// <returns>Amount in CAD</returns>
        public decimal ConvertCurrency(string currency, decimal amt)
        {
            //Divide the entered amount with selected currency conversion rate 
            return amt / Currencies[currency];
        }
    }
}
