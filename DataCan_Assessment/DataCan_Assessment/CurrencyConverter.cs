using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCan_Assessment
{
    internal class CurrencyConverter
    {
        //Currency Dictionary - Contains all the different currencies and conversion rates
        Dictionary<string, decimal> Currencies = new Dictionary<string, decimal>()
        {
            { "CAD",  1.00m  },
            { "USD",  0.50m  },
            { "MXN",  10.00m },
            { "EURO", 0.25m  }
        };

        /// <summary>
        /// Converts the specified amount from a foreign currency to CAD based on the current exchange rate.
        /// More methods for different kinds of conversion could be easily added in this class 
        /// </summary>
        /// <param name="currency">Selected conversion currency</param>
        /// <param name="amt">Amount entered to be deposited or withdrawn</param>
        /// <returns>Amount in CAD</returns>
        public decimal ConvertToCAD(string currency, decimal amt)
        {
            //Divide the entered amount with selected currency conversion rate 
            return amt / Currencies[currency];
        }
    }
}
