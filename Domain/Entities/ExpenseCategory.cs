using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entities.Enumerations.Enums;

namespace Domain.Entities
{
    [Table("ExpenseCategories")]
    public class ExpenseCategory : BaseEntity
    {
        public string Name { get; set; }
        public TypeExpenseCategory Type { get; set; }

        // Relations
        public virtual List<Transaction> Transactions { get; set; }
    }
}
