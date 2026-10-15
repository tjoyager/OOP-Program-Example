using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedPayment
{
    public class BankTransferPayment : PaymentMethod
    {
        public string BankAccount { get; set; }

        public BankTransferPayment(string accountHolder, string bankAccount)
            : base(accountHolder)
        {
            BankAccount = bankAccount;
        }

        public override void Authenticate()
        {
            Console.WriteLine($"{AccountHolder}: Authenticating bank transfer...");
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{AccountHolder}: Paying {amount:C} via bank transfer.");
        }
    }

}
