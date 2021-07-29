using System;
using System.ComponentModel.DataAnnotations;

namespace Financial.Shared.Models
{
    public class TransactionViewModel
    {
        public Guid Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Subject { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
    }
}