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
        Account acc = null;
        double balance = 1000;

        Dictionary<string,double>Currencies = new Dictionary<string, double>() 
        {
            { "CAD",  1.00  },
            { "USD",  0.50  },
            { "MXN",  10.00 },
            { "EURO", 0.25  }
        };

        public Form1()
        {
            InitializeComponent();
            UI_DropDown_Currencies.SelectedIndex = 0;
            UI_DropDown_AccountNum.SelectedIndex = 0;
            acc = new Account(balance);
            UpdateUI();
        }

        private void UI_Btn_Deposit_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                double.TryParse(UI_TxtBox_Amount.Text, out amount);
                acc.Deposit(ConvertCurrency(UI_DropDown_Currencies.Text, amount));
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
          
        }

        private void UI_Btn_WIthdraw_Click(object sender, EventArgs e)
        {
            double amount = 0;
            double.TryParse(UI_TxtBox_Amount.Text, out amount);
            acc.Withdraw(ConvertCurrency(UI_DropDown_Currencies.Text,amount));
            UpdateUI();
        }

        public void UpdateUI()
        {
            UI_TxtBox_Balance.Text = "$" + acc.Balance.ToString();
            Console.WriteLine(acc.Balance.ToString());
        }

        public double ConvertCurrency(string currency,double amt)
        {

           return amt / Currencies[currency];   
            
        }
    }

    public class Account
    {
        public Account(double bal)
        {
            Balance = bal;
        }
        public double Balance { get; set; }
        
        public void Withdraw(double amt)
        {
            if (Balance < amt) 
            {
                MessageBox.Show("Insufficient Funds");
            }
            else
            {
                Balance -= amt;
            }
        }
        public void Deposit(double amt) 
        {
            Balance += amt;
        }
    }
   

}
