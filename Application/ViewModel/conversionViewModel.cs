using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class conversionViewModel
    {
        public double Amount { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }

        public double Result
        {
            get
            {
                
                double pesoToDollarRate = 0.018; 
                double pesoToEuroRate = 0.015;   
                double euroToDollarRate = 1.20; 

                double result = 0;

                if (FromCurrency == "peso" && ToCurrency == "dolar")
                {
                    result = Amount * pesoToDollarRate;
                }
                else if (FromCurrency == "dolar" && ToCurrency == "peso")
                {
                    result = Amount / pesoToDollarRate;
                }
                else if (FromCurrency == "peso" && ToCurrency == "euro")
                {
                    result = Amount * pesoToEuroRate;
                }
                else if (FromCurrency == "euro" && ToCurrency == "peso")
                {
                    result = Amount / pesoToEuroRate;
                }
                else if (FromCurrency == "euro" && ToCurrency == "dolar")
                {
                    result = Amount * euroToDollarRate;
                }
                else if (FromCurrency == "dolar" && ToCurrency == "euro")
                {
                    result = Amount / euroToDollarRate;
                }
                else if (FromCurrency == "peso" && ToCurrency == "peso")
                {
                    result = Amount;
                }
                else if (FromCurrency == "euro" && ToCurrency == "euro")
                {
                    result = Amount;
                }
                else if (FromCurrency == "dolar" && ToCurrency == "dolar")
                {
                    result = Amount;
                }

                return result;
            }
        }
    }

   
}
