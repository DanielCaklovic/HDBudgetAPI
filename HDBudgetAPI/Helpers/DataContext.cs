using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HDBudgetAPI.Entities;

namespace HDBudgetAPI.Helpers
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}