using Job.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.DataAccess.DatabaseContext
{
    public class KurtulanContext:DbContext
    {
        public DbSet<MUSTERI> MUSTERI { get; set; }
    }
}
