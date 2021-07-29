using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Financial.Shared.Domains
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(30)]
        public string CategoryName { get; set; }
        [Required]
        public TransactionType CategoryType { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}