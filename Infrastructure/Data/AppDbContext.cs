using Domain.Entities;
using Domain.Entities.Authentication;
using Domain.Entities.Logs;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        // Project Entities  
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<GoalContribution> GoalContributions { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        // Logs
        public DbSet<Log> Logs { get; set; }

    }
}
