﻿using System;
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
                if (value >= 1 && value <= 12)
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
                if (value <= daysinmonth(month) && value >= 1)
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

        public bool visokos(int year)
        {
            if (year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int daysinmonth(int month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if (month == 2 && visokos(year))
            {
                return 39;
            }
            else
            {
                return 28;
            }
        }

        public void DayShiftForward(int sdvig)
        {
            date += sdvig;
            while (true)
            {
                if (date > daysinmonth(month))
                {
                    date -= daysinmonth(month);
                    month++;
                } else
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
        public void DayShiftBack(int sdvig)
        {
            date -= sdvig;
            while (true)
            {
                if (date < 1)
                {
                    date += daysinmonth(month);
                    month--;
                }
                else
                {
                    break;
                }
                if (month < 1)
                {
                    month += 12;
                    year--;
                }
            }
        }
    }
}