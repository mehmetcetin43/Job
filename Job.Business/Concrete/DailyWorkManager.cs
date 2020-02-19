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
            return _efDailyWorkDal.Get(u => u.ID == id);
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
                if (item == 1) monts.Add("January");
                else if (item == 2) monts.Add("February");
                else if (item == 3) monts.Add("March");
                else if (item == 4) monts.Add("April");
                else if (item == 5) monts.Add("March");
                else if (item == 6) monts.Add("June");
                else if (item == 7) monts.Add("July");
                else if (item == 8) monts.Add("August");
                else if (item == 9) monts.Add("September");
                else if (item == 10) monts.Add("October");
                else if (item == 11) monts.Add("November");
                else if (item == 12) monts.Add("December");
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

        public int TotalExtraWork(int year, int month)
        {
            var result = 0;
            var totalExtraWork = _efDailyWorkDal.GetList().Where(u => u.Date.Month == month && u.Date.Year == year).Select(u => u.ExtraWorkingHour).ToList();
            foreach (var item in totalExtraWork)
            {
                result = result + Convert.ToInt32(item.Value.TotalMinutes);
            }
            return result;
        }

        public int TotalMissingWork(int year, int month)
        {
            var result = 0;
            var totalMissingWork = _efDailyWorkDal.GetList().Where(u => u.Date.Month == month && u.Date.Year == year).Select(u => u.MissingWorkingHour).ToList();
            foreach (var item in totalMissingWork)
            {
                result = result + Convert.ToInt32(item.Value.TotalMinutes);
            }
            return result;
        }

        public decimal CalculateSalary(int year, int month, int salary, decimal hourlyWage)
        {
            //decimal result = 0;

            //var data = _efDailyWorkDal.GetList().Where(r => r.Date.Year == year && r.Date.Month == month);
            //foreach (var item in data)
            //{
            //    result = result + Convert.ToDecimal(item.ExtraWorkingHour.Value.TotalMinutes - item.MissingWorkingHour.Value.TotalMinutes);
            //}
            //result = (result / 60) * 1.5M * (hourlyWage);
            //return salary + result;


            decimal holidayExtraSalary;
            decimal weekdaysExtraSalary;
            decimal totalSalary;
            var dataHolidayExtra = _efDailyWorkDal.GetList().Where(r => r.Date.Year == year && r.Date.Month == month && (r.Date.DayOfWeek==DayOfWeek.Sunday || r.Date.DayOfWeek == DayOfWeek.Saturday))
                .Select(t=>t.ExtraWorkingHour.Value.TotalMinutes).Sum();
            var dataWeekDaysExtra = _efDailyWorkDal.GetList().Where(r => r.Date.Year == year && r.Date.Month == month && (r.Date.DayOfWeek != DayOfWeek.Sunday) && (r.Date.DayOfWeek != DayOfWeek.Saturday))
                .Select(t => t.ExtraWorkingHour.Value.TotalMinutes).Sum();
            var dataMissing = _efDailyWorkDal.GetList().Where(r => r.Date.Year == year && r.Date.Month == month).Select(t => t.MissingWorkingHour.Value.TotalMinutes).Sum();
            if (dataHolidayExtra >= dataMissing)
            {
                dataHolidayExtra = dataHolidayExtra - dataMissing;
                dataWeekDaysExtra = dataWeekDaysExtra;
            }
            else if (dataHolidayExtra < dataMissing)
            {
                dataHolidayExtra = -(dataMissing - dataHolidayExtra);
                dataWeekDaysExtra = dataWeekDaysExtra + dataHolidayExtra;
            }

            if (dataHolidayExtra>=0)
            {
                holidayExtraSalary = Convert.ToDecimal(dataHolidayExtra) / 60 * 2M *  hourlyWage;
                weekdaysExtraSalary = Convert.ToDecimal(dataWeekDaysExtra) / 60 * 1.5M *  hourlyWage;
                totalSalary = salary + holidayExtraSalary + weekdaysExtraSalary;
            }
            else
            {
                holidayExtraSalary = 0M;
                weekdaysExtraSalary = Convert.ToDecimal(dataWeekDaysExtra) / 60 * 1.5M *  hourlyWage;
                totalSalary = salary + weekdaysExtraSalary;
            }

            return totalSalary;
        }

        public decimal HourlyWage(int month, decimal salary)
        {
            decimal hours = 0;
            DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
            DateTime _1_January = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime _23_April = new DateTime(DateTime.Now.Year, 4, 23);
            DateTime _1_May = new DateTime(DateTime.Now.Year, 5, 1);
            DateTime _30_August = new DateTime(DateTime.Now.Year, 4, 23);
            DateTime _29_October = new DateTime(DateTime.Now.Year, 4, 23);
            var days = DateTime.DaysInMonth(DateTime.Now.Year, month);
            for (int i = 1; i <= days; i++)
            {
                hours =
                    firstDay.Date == _1_January || firstDay.Date == _1_May || firstDay.Date == _23_April || firstDay.Date == _29_October || firstDay.Date == _30_August ? hours
                    : firstDay.DayOfWeek == DayOfWeek.Monday
                    || firstDay.DayOfWeek == DayOfWeek.Tuesday
                    || firstDay.DayOfWeek == DayOfWeek.Wednesday
                    || firstDay.DayOfWeek == DayOfWeek.Thursday
                    || firstDay.DayOfWeek == DayOfWeek.Friday ? hours = hours + 8
                    : firstDay.DayOfWeek == DayOfWeek.Saturday ? hours = hours + 5

                    : hours;

                //if (firstDay.DayOfWeek==DayOfWeek.Monday || firstDay.DayOfWeek == DayOfWeek.Tuesday
                //    || firstDay.DayOfWeek == DayOfWeek.Wednesday || firstDay.DayOfWeek == DayOfWeek.Thursday 
                //    || firstDay.DayOfWeek == DayOfWeek.Friday)
                //{
                //    hours = hours + 8;
                //}
                firstDay = firstDay.AddDays(1);
            }

            decimal wage = salary / hours;
            return wage;

        }
    }
}
