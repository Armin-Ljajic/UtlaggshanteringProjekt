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

        //Inject application db context in constructor
        public UserExpenseController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Get list of expenses from database
        [HttpGet]
        public async Task<ActionResult<UserExpense>> GetAllUserExpensesAsync()
        {
            return Ok(await _applicationDbContext.UserExpenses.ToListAsync());
        }

        //Add expense to database
        [HttpPost]
        public async Task<ActionResult<UserExpense>> CreateUserExpenseAsync(UserExpense userExpense)
        {
            _applicationDbContext.UserExpenses.Add(userExpense);
            await _applicationDbContext.SaveChangesAsync();

            return Ok(userExpense);
        }

        //Update expense in database
        [HttpPut]
        public async Task<ActionResult<UserExpense>> UpdateUserExpenseAsync(UserExpense userExpense)
        {
            _applicationDbContext.Entry(userExpense).State = EntityState.Modified;
            await _applicationDbContext.SaveChangesAsync();

            return Ok(userExpense);

        }
    }
}
