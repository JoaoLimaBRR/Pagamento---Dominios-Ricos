using PaymentContext.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType eDocumentType)
        {
            Number = number;
            DocumentType = eDocumentType;
        }

        public string Number { get; private set; }
        public EDocumentType DocumentType { get; set; }
    }
}
