
using InterfaceBasedPayment;

PaymentMethod[] payments = new PaymentMethod[]
        {
            new CreditCardPayment("Alice", "4111-xxxx"),
            new BankTransferPayment("Bob", "123456789"),
            new EWalletPayment("Charlie", "e-wallet-xyz")
        };

foreach (var payment in payments)
{
    payment.Authenticate();
    payment.ProcessPayment(100.00m);

    if (payment is IRefundable refundable)
    {
        refundable.Refund(25.00m);
    }

    Console.WriteLine();
}
