using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial.Shared.Domains;
using Microsoft.EntityFrameworkCore;

namespace Financial.Api.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FinancialDbContext _context;

        public CategoryRepository(FinancialDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.OrderBy(c => c.CategoryName).ToListAsync();
        }

        public async Task<Category> GetById(Guid id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Category> AddNewCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}