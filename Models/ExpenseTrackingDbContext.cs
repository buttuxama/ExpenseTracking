using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracking.Models
{
    public class ExpenseTrackingDbContext: DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseTrackingDbContext(DbContextOptions<ExpenseTrackingDbContext> options) : base(options)
        {
            
        }
    }
}