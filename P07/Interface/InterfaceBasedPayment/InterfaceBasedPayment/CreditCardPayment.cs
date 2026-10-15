using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedPayment
{
    public class CreditCardPayment : PaymentMethod, IRefundable
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string accountHolder, string cardNumber)
            : base(accountHolder)
        {
            CardNumber = cardNumber;
        }

        public override void Authenticate()
        {
            Console.WriteLine($"{AccountHolder}: Authenticating credit card...");
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{AccountHolder}: Paying {amount:C} using credit card.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"{AccountHolder}: Refunding {amount:C} to credit card.");
        }
    }

}
