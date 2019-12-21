using Job.Core.DataAccess.EntityFramework;
using Job.DataAccess.Abstract;
using Job.DataAccess.DatabaseContext;
using Job.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.DataAccess.Concrete
{
    public class EfMusteriDal:EfEntityRepositoryBase<MUSTERI,KurtulanContext>, IMusteriDal
    {
    }
}
