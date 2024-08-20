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
        CurrencyConverter convertCurrency = null;

        //Hardcoded starting account balance
        const decimal balance = 1000;
        
        public Form1()
        {
            InitializeComponent();
            //Currency & account number starting selection
            currencyDropdown.SelectedIndex = 0;
            AccountNum_DropDown.SelectedIndex = 0;
            //Create new account object with the starting balance
            acc = new Account(balance);
            //Update the total balance textbox
            convertCurrency = new CurrencyConverter();
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
                acc.Deposit(convertCurrency.ConvertToCAD(currencyDropdown.Text, amount));
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
                acc.Withdraw(convertCurrency.ConvertToCAD(currencyDropdown.Text, amount));
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
    }
}
