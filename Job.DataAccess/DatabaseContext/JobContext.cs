using Job.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.DataAccess.DatabaseContext
{
    public class JobContext:DbContext
    {
        public DbSet<DailyWork> DailyWorks { get; set; }
    }
   
}
