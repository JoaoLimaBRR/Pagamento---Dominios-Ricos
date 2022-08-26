using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(Email email, string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress) 
            : base(paidDate, expireDate, total, totalPaid, document, payer, adress)
        {
            Email = email;
            TransactionCode = transactionCode;
        }

        public Email Email { get; private set; }
        public string TransactionCode { get; private set; }
    }
}
