using System;

namespace InterfaceBasedPayment
{
    public abstract class PaymentMethod
    {
        public string AccountHolder { get; set; }

        public PaymentMethod(string accountHolder)
        {
            AccountHolder = accountHolder;
        }

        public abstract void Authenticate();
        public abstract void ProcessPayment(decimal amount);
    }

}
