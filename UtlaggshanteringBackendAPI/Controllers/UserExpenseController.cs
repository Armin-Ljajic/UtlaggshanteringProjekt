using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utläggningshantering.Context;
using Utläggningshantering.Models;

namespace UtlaggshanteringBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserExpenseController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserExpenseController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<UserExpense>> GetAllUserExpensesAsync()
        {
            return Ok(await _applicationDbContext.UserExpenses.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<UserExpense>> CreateUserExpenseAsync(UserExpense userExpense)
        {
            _applicationDbContext.UserExpenses.Add(userExpense);
            await _applicationDbContext.SaveChangesAsync();

            return Ok(userExpense);
        }

        [HttpPut]
        public async Task<ActionResult<UserExpense>> UpdateUserExpenseAsync(UserExpense userExpense)
        {
            _applicationDbContext.Entry(userExpense).State = EntityState.Modified;
            await _applicationDbContext.SaveChangesAsync();

            return Ok(userExpense);

        }
    }
}
