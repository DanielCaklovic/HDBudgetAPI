using HDBudgetAPI.Entities;
using HDBudgetAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDBudget.Helpers
{
    /// <summary>
    /// Database initializer.
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// Initializes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        public static void Initialize(DataContext context)
        {
            context.Database.Migrate();

            var testUser = new User()
            {
                Id = Guid.Parse("e96bf6d6-3c62-41a9-8ecf-1bd23af931c9"),
                FirstName = "test",
                LastName = "test1",
                Username = "testuser"
            };

            if (!context.Users.Any())
            {
                context.Users.Add(testUser);
            }

            bool success = context.SaveChanges() > 0;
        }
    }
}
