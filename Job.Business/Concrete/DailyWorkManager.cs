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
    public class DailyWorkManager : IDailyWorkService
    {
        private IDailyWorkDal _efDailyWorkDal;
        public DailyWorkManager(IDailyWorkDal efDailyWorkDal)
        {
            _efDailyWorkDal = efDailyWorkDal;
        }

        public DailyWork Add(DailyWork entity)
        {
            return _efDailyWorkDal.Add(entity);
        }
        public DailyWork Update(DailyWork dailyWork)
        {
            return _efDailyWorkDal.Update(dailyWork);
        }
        public void Delete(DailyWork daily)
        {
            _efDailyWorkDal.Delete(daily);
        }

        public DailyWork GetByID(int id)
        {
          return  _efDailyWorkDal.Get(u => u.ID == id);
        }

        public List<DailyWork> GetAll()
        {
            return _efDailyWorkDal.GetList();
        }

        public List<DailyWork> GetByYearsMonth(int year, int month)
        {
            var result = _efDailyWorkDal.GetList().Where(u => u.Date.Year == year & u.Date.Month == month).ToList();
            return result;
        }

        public DailyWork GetDate(DateTime date)
        {
            var result = _efDailyWorkDal.Get(u => u.Date == date);
            return result;
        }

        public List<string> GetMonthsByName(int year)
        {
            var result = _efDailyWorkDal.GetList().Where(u => u.Date.Year == year).OrderBy(x => x.Date).Select(u => u.Date.Month).Distinct().ToList();
            List<string> monts = new List<string>();
            foreach (var item in result)
            {
                if (item == 1)  monts.Add("January");
                else if (item == 2)  monts.Add("February");
                else if (item == 3)  monts.Add("March");
                else if (item == 4)  monts.Add("April");
                else if (item == 5)  monts.Add("March");
                else if (item == 6)  monts.Add("June");
                else if (item == 7)  monts.Add("July");
                else if (item == 8)  monts.Add("August");
                else if (item == 9)  monts.Add("September");
                else if (item == 10)  monts.Add("October");
                else if (item == 11)  monts.Add("November");
                else if (item == 12)  monts.Add("December");
            }
            return monts;
        }
        public List<int> GetMonthsByNumber(int year)
        {
            var result = _efDailyWorkDal.GetList().Where(u => u.Date.Year == year).OrderBy(x => x.Date).Select(u => u.Date.Month).Distinct().ToList();
            return result;
        }

        public List<int> GetYears()
        {
            var result = _efDailyWorkDal.GetList().OrderBy(x => x.Date).Select(u => u.Date.Year).Distinct().ToList();
            return result;
        }

        public int TotalExtraWork(int year,int month)
        {
            var result = 0;
            var totalExtraWork = _efDailyWorkDal.GetList().Where(u => u.Date.Month == month&& u.Date.Year==year).Select(u => u.ExtraWorkingHour).ToList();
            foreach (var item in totalExtraWork)
            {
                result = result + Convert.ToInt32(item.Value.TotalMinutes);
            }
            return result;
        }

        public int TotalMissingWork(int year,int month)
        {
            var result = 0;
            var totalMissingWork = _efDailyWorkDal.GetList().Where(u => u.Date.Month == month&&u.Date.Year==year).Select(u => u.MissingWorkingHour).ToList();
            foreach (var item in totalMissingWork)
            {
                result = result + Convert.ToInt32(item.Value.TotalMinutes);
            }
            return result;
        }
    }
}
