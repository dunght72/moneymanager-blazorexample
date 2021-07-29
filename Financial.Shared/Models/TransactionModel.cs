using System;
using System.ComponentModel.DataAnnotations;
using Financial.Shared.Domains;

namespace Financial.Shared.Models
{
    public class TransactionModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        public Guid CategoryId { get; set; }

        public TransactionType Type { get; set; }
        
        [Required]
        public decimal Amount { get; set; }
    }
}