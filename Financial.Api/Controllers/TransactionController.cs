using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial.Api.Repository;
using Financial.Shared.Domains;
using Financial.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Financial.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TransactionController : ControllerBase
    {
        

        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TransactionController(ILogger<TransactionController> logger,ITransactionRepository transactionRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions([FromQuery]string subject,Guid? categoryId)
        {
            var transactions = await _transactionRepository.GetAll();
            if (!String.IsNullOrEmpty(subject))
            {
                transactions = transactions.Where(x => x.Subject.ToLower().Contains(subject.ToLower()));
            }

            if (categoryId.HasValue)
            {
                transactions = transactions.Where(x => x.CategoryId == categoryId);
            }
            var result = transactions.Select(t => new TransactionViewModel()
            {
                Id = t.Id,
                Subject = t.Subject,
                CategoryName = t.Category.CategoryName,
                Amount = t.Amount,
                Date = t.Date
            });
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryRepository.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetTransactionDetail(Guid id)
        {
            var transaction = await _transactionRepository.GetById(id);
            if (transaction == null)
            {
                return NotFound();
            }

            TransactionUpdateModel model = new TransactionUpdateModel()
            {
                Id = transaction.Id,
                Subject = transaction.Subject,
                CategoryId = transaction.CategoryId,
                Amount = transaction.Amount,
                Date = transaction.Date
            };
            return Ok(model);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCategoryDetail(Guid id)
        {
            var category = await _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddTransaction(TransactionModel model)
        {
            if (ModelState.IsValid)
            {
                Transaction transaction = new Transaction()
                {
                    Id = Guid.NewGuid(),
                    Date = model.Date,
                    Subject = model.Subject,
                    CategoryId = model.CategoryId,
                    TransactionType = model.Type,
                    Amount = model.Amount

                };
                await _transactionRepository.Add(transaction);
                return CreatedAtAction(nameof(GetTransactionDetail), new {Id = transaction.Id}, transaction);
            }

            return BadRequest();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = model.CategoryName,
                    CategoryType = model.CategoryType
                    
                };
                await _categoryRepository.AddNewCategory(category);
                return CreatedAtAction(nameof(GetCategoryDetail), new {Id = category.Id}, category);
            }

            return BadRequest();
        }

        
        // Remove transaction
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTransaction(Guid id)
        {
            var transaction = await _transactionRepository.GetById(id);
            if (transaction == null)
            {
                return BadRequest();
            }
            _transactionRepository.Remove(transaction);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTransaction([FromQuery] Guid id,
            [FromBody] TransactionUpdateModel transactionViewModel)
        {
            var transaction = await _transactionRepository.GetById(id);
            if (transaction == null)
            {
                return BadRequest();
            }

            transaction.Amount = transactionViewModel.Amount;
            transaction.CategoryId = transactionViewModel.CategoryId;
            transaction.Subject = transactionViewModel.Subject;
            transaction.Date = transactionViewModel.Date;
            await _transactionRepository.Update(transaction);
            return NoContent();
        }
    }
}
