using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class Payment
    {
        public string Name;
        public double Salary;
        public DateTime Year;
        public double Allowance;
        public double Tax;
        public double DaysInMonth; //кол-во рабочих дней
        public double WorkingDaysmounth; //кол-во отработанных дней
        public double Accruedamount; //начисленная сумма
        public double Amountwithheld; //удержанная сумма

        public Payment(string name, double salary, DateTime year, double allowance, double tax, double daysInMonth, double workingDaysmounth, double accruedamount, double amountwithheld)
        {
            Name = name;
            Salary = salary;
            Year = year;
            Allowance = allowance;
            Tax = tax;
            DaysInMonth = daysInMonth;
            WorkingDaysmounth = workingDaysmounth;
            Accruedamount = accruedamount;
            Amountwithheld = amountwithheld;
        }

        public double GetSalary()
        {
            return (WorkingDaysmounth/DaysInMonth*Salary);
        }
        public double GetAmountWithheld()
        {
            return (Accruedamount / 100 * 99) / 100 * 87;
        }
        public TimeSpan GetYear()
        {
            return DateTime.Now.Subtract(Year);
        }

    }
}
