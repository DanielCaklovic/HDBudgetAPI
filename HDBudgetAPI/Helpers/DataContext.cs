using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HDBudgetAPI.Entities;
using System;
using HDBudget.Helpers;

namespace HDBudgetAPI.Helpers
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}