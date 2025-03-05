using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public required string Name { get; set; }

       // public ICollection<Routine> Routines { get; set; }

    }
}
