using Domain.Entities.Authentication;
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
    [Table("Goals")]
    public class Goals : BaseEntity
    {
        [ForeignKey("User")]
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }

        public string Name { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TargetAmount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CurrentAmount { get; set; }
        public DateTime Deadline { get; set; }
        public string? Description { get; set; }
        public GoalStatus Status { get; set; }

        // Relations
        public virtual List<GoalContribution> GoalContributions { get; set; }
    }
}
