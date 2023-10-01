using DataTransformerGenericExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise.Models
{
    public class Invoice : ITransformable
    {
        public int InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public Invoice(int invoiceNumber, DateTime date, decimal amount)
        {
            InvoiceNumber = invoiceNumber;
            Date = date;
            Amount = amount;
        }

        public object TransformToObject()
        {
            return new
            {
                objInvoiceNumber = InvoiceNumber,
                objAmount = Amount
            };
        }
    }
}
