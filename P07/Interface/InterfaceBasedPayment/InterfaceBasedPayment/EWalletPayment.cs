using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedPayment
{
    public class EWalletPayment : PaymentMethod, IRefundable
    {
        public string WalletId { get; set; }

        public EWalletPayment(string accountHolder, string walletId)
            : base(accountHolder)
        {
            WalletId = walletId;
        }

        public override void Authenticate()
        {
            Console.WriteLine($"{AccountHolder}: Logging into e-wallet...");
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{AccountHolder}: Paying {amount:C} from e-wallet.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"{AccountHolder}: Refunding {amount:C} to e-wallet.");
        }
    }

}
