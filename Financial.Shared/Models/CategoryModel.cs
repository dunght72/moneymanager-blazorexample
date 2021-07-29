using System;

namespace Financial.Shared.Models
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public TransactionType CategoryType { get; set; }
        
    }
}