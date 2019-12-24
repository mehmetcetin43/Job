using Job.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Business.Abstract
{
    public interface IDailyWorkService
    {
        List<DailyWork> GetAll();
        List<int> GetYears();
        List<int> GetMonthsByNumber(int year);
        List<string> GetMonthsByName(int year);
        List<DailyWork> GetByYearsMonth(int year,int month);
        DailyWork Add(DailyWork entity);
        DailyWork GetByID(int id);

        int TotalExtraWork(int year,int month);
        int TotalMissingWork(int year,int month);
        DailyWork GetDate(DateTime date);
        DailyWork Update(DailyWork daily);
        void Delete(DailyWork daily);

        decimal CalculateSalary(int year, int month,int salary, decimal hourlyWage);
        decimal HourlyWage(int month,decimal salary);
    }
}
