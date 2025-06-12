using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker_Capstone.Models;

namespace ExpenseTracker_Capstone.Data
{
    public class ExpenseTracker_CapstoneContext : DbContext
    {
        public ExpenseTracker_CapstoneContext (DbContextOptions<ExpenseTracker_CapstoneContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseTracker_Capstone.Models.Expense> Expense { get; set; } = default!;
    }
}
