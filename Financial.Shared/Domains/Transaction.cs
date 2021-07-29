using System;

namespace Financial.Shared.Domains
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime Date { get; set; }

        public string Subject { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public decimal Amount { get; set; }
    }
}