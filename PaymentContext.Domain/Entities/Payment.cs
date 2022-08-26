namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment( DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document, string payer, string adress)
        {
            Number = Guid.NewGuid().ToString();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Document = document;
            Payer = payer;
            Adress = adress;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Decimal Total { get; private set; }
        public Decimal TotalPaid { get; private set; }
        public string Document { get; private set; }
        public string Payer { get; private set; }
        public string Adress { get; private set; }
    }
}
