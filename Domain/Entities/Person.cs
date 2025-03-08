using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Persons")]
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
    }
}
