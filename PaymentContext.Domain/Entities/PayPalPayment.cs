namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string email, string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document, string payer, string adress) 
            : base(paidDate, expireDate, total, totalPaid, document, payer, adress)
        {
            Email = email;
            TransactionCode = transactionCode;
        }

        public string Email { get; private set; }
        public string TransactionCode { get; private set; }
    }
}
