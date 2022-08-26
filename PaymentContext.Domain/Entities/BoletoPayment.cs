using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, Email email, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress)
            : base(paidDate, expireDate, total, totalPaid, document, payer, adress)
        {
            BarCode = barCode;
            Email = email;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public Email Email { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
