using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class DateTime : Time
    {

        private int year, month, date;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value != 0)
                {
                    year = value;
                }
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    month = value;
                }
            }
        }
        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                if (((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && value <= 31 && value >= 0) || ((month == 4 || month == 6 || month == 9 || month == 11) && value <= 30 && value >= 0) || (month == 2 && (year % 4 != 0 || year % 100 == 0 && year % 400 != 0) && value >=0 && value <= 28) || (month == 2 && (year % 4 == 0 || year % 400 == 0) && value >= 0 && value <= 29 ))
                {
                    date = value;
                }
            }
        }
        public DateTime(int year, int month, int date, int hour, int minute, int second) :
            base(hour, minute, second)
        {
            this.Year = year;
            this.Month = month;
            this.Date = date;
        }

        public void DayShift(int sdvig)
        {
            date += sdvig;
            while (true)
            {
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && date > 31)
                {
                    date -= 31;
                    month++;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && date > 30)
                {
                    date -= 30;
                    month++;
                }
                else if (month == 2 && (year % 4 != 0 || year % 100 == 0 && year % 400 != 0) && date > 28)
                {
                    date -= 28;
                    month++;
                }
                else if (month == 2 && (year % 4 == 0 || year % 400 == 0) && date > 29)
                {
                    date -= 29;
                    month++;
                }
                else
                {
                    break;
                }
                if (month > 12)
                {
                    month -= 12;
                    year++;
                }
            }
        }
    }
}
