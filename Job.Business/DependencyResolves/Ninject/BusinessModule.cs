using Job.Business.Abstract;
using Job.Business.Concrete;
using Job.DataAccess.Abstract;
using Job.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Business.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDailyWorkService>().To<DailyWorkManager>().InSingletonScope();
            Bind<IDailyWorkDal>().To<EfDailyWorkDal>().InSingletonScope();

        }
    }
}
