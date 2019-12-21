using Job.Business.Abstract;
using Job.DataAccess.Abstract;
using Job.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private IMusteriDal _efMusteriDal;

        public MusteriManager(IMusteriDal efMusteriDal)
        {
            _efMusteriDal = efMusteriDal;
        }
        public List<MUSTERI> GetAll()
        {
            return _efMusteriDal.GetList();
        }
    }
}
