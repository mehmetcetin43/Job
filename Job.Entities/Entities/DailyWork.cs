using Job.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Entities.Entities
{
    [Table("DailyWork")]
    public partial class DailyWork : IEntity
    {
        //[Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string  CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        public string DailyWorkingHour { get; set; }
        public TimeSpan? ExtraWorkingHour { get; set; }
        public TimeSpan? MissingWorkingHour { get; set; }
    }
}
