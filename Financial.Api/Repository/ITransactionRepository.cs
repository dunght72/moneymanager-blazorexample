using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financial.Shared.Domains;

namespace Financial.Api.Repository
{
    public interface ITransactionRepository
    {
        Task<Transaction> Add(Transaction transaction);
        void Remove(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
        Task<IEnumerable<Transaction>> GetAll();
        Task<Transaction> GetById(Guid id);
        

    }
}