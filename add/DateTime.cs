using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class DateTime : Time
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public DateTime(int year, int month, int date, int hour, int minute, int second) :
            base(hour, minute, second)
        {
            this.Year = year;
            this.Month = month;
            this.Date = date;
        }
        public void DayShift(int sdvig)
        {
            Date += sdvig;
        }
    }
}
