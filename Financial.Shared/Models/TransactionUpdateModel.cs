using System;
using System.ComponentModel.DataAnnotations;

namespace Financial.Shared.Models
{
    public class TransactionUpdateModel
    {
        public Guid Id { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}