using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    using System;

    internal class Date
    {
        private uint year;
        private uint month;
        private uint day;

        public Date(uint year, uint month, uint day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(string dateStr)
        {
            string[] parts = dateStr.Split('.');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid date format");
            }
            year = uint.Parse(parts[0]);
            month = uint.Parse(parts[1]);
            day = uint.Parse(parts[2]);
        }

        public Date(DateTime dateTime)
        {
            year = (uint)dateTime.Year;
            month = (uint)dateTime.Month;
            day = (uint)dateTime.Day;
        }

        public void AddDays(int days)
        {
            var date = ToDateTime();
            date = date.AddDays(days);
            year = (uint)date.Year;
            month = (uint)date.Month;
            day = (uint)date.Day;
        }

        public void SubtractDays(int days)
        {
            AddDays(-days);
        }

        public bool IsLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        public uint Year
        {
            get { return year; }
            set { year = value; }
        }

        public uint Month
        {
            get { return month; }
            set { month = value; }
        }

        public uint Day
        {
            get { return day; }
            set { day = value; }
        }

        public int CompareTo(Date other)
        {
            if (year != other.year)
            {
                return year.CompareTo(other.year);
            }
            if (month != other.month)
            {
                return month.CompareTo(other.month);
            }
            return day.CompareTo(other.day);
        }

        public int DaysBetween(Date other)
        {
            var date1 = ToDateTime();
            var date2 = other.ToDateTime();
            return Math.Abs((date1 - date2).Days);
        }

        public override string ToString()
        {
            return $"{year}.{month:d2}.{day:d2}";
        }

        private DateTime ToDateTime()
        {
            return new DateTime((int)year, (int)month, (int)day);
        }
    }
}
