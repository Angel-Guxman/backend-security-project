using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("GoalContributions")]
    public class GoalContribution : BaseEntity
    {
        [ForeignKey("Goals")]
        public int GoalID { get; set; }
        public Goals Goals { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        public DateTime ContributionDate { get; set; }
    }
}
