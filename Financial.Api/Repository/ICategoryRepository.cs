using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financial.Shared.Domains;

namespace Financial.Api.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(Guid id);
        Task<Category> AddNewCategory(Category category);
        
    }
}