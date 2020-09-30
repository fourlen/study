using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    public class Time
    {
        private int second, minute, hour;

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
            }
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    hour = value;
                }
            }
        }
        public Time(int t_hour, int t_minute, int t_second)
        {
            Second = t_second;
            Minute = t_minute;
            Hour = t_hour;
        }
        public int Timeinsec(int hour, int minute, int second)
        {
            return hour * 3600 + minute * 60 + second;
        }

        public void Shift(int sdvig)
        {
            hour = (hour + sdvig / 3600) % 24;
            minute = (minute + sdvig % 3600) / 60;
            second = (second + sdvig % 3600) % 60;
        }
    }
}