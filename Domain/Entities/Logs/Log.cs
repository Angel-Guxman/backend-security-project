using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entities.Enumerations.Enums;

namespace Domain.Entities.Logs
{
    [Table("Logs")]
    public class Log
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime LogDate { get; set; }
        public LogsClassification Classification { get; set; }
    }
}
