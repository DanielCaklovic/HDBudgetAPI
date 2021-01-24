using HDBudgetAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDBudgetAPI.Entities
{
    public class Expense
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ExpenseCategoryType Category { get; set; }
    }
}
