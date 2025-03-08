using Domain.Entities.Authentication;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Transactions")]
    public class Transaction : BaseEntity
    {
        [ForeignKey("User")]
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("ExpenseCategory")]
        public int CategoryID { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
    }
}
