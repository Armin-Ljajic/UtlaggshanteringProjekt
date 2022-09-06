using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utläggningshantering.Models;

namespace Utläggningshantering.Context
{
    public class ApplicationDbContext : DbContext
    {
        //Application context
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Dbset UserExpenses
        public DbSet<UserExpense> UserExpenses { get; set; }
    }
}
