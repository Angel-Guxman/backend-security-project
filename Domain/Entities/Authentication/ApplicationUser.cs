using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public required string Name { get; set; }

        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public Person Person { get; set; }


        // Relations
        public virtual List<Goals> Goals { get; set; }
        public virtual List<Transaction> Transactions { get; set; }

        // public ICollection<Routine> Routines { get; set; }
    }
}
