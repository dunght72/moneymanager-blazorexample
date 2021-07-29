using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial.Shared.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Financial.Api.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly FinancialDbContext _context;

        public TransactionRepository(FinancialDbContext context)
        {
            _context = context;
        }
        public async Task<Transaction> Add(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async void Remove(Transaction transaction)
        {
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task<Transaction> Update(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<IEnumerable<Transaction>> GetAll()
        {
            return await _context.Transactions.Include(d => d.Category).OrderByDescending(d => d.Date).ToListAsync();
        }

        public async Task<Transaction> GetById(Guid id)
        {
            var transaction =await  _context.Transactions.Include(e => e.Category).FirstOrDefaultAsync(e => e.Id == id);
            return transaction;
        }

        
    }
}