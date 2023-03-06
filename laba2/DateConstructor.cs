using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class DateConstructor
    {
        private int year;
        private int month;
        private int day;
        private DateTime time;
        public int Year { get; set; }
        public int Month { get { return month; } set { if (value <= 12) month = value; } }
        public int Day { get { return day; } set { if (value <= 31) Day= value; } }

        public DateConstructor( int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public override string ToString()
        {
            return Year + " " + Month + " " + Day;
        }
    }
}
