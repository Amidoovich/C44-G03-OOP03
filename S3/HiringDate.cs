using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    internal class HiringDate
    {
        #region Attributes
        private int day;

        private int month;

        private int year;
        #endregion

        #region Constructor
        public HiringDate(int day,int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Full Property
        public int Day
        {
            get { return day; }
            set
            {
                if (value <= 0 || value > 31)
                {
                    Console.WriteLine("Day must be between 1 and 31");
                    day = DateTime.Now.Day;
                }
                    
                else
                    day = value;       

            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value <= 0 || value >12)
                {
                    Console.WriteLine("Month must be between 1 and 12");
                    month = DateTime.Now.Month;
                }
                    
                else
                    month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 1980 || value > DateTime.Now.Year )
                {
                    Console.WriteLine($"Year must between 1980 and {DateTime.Now.Year}");
                    year = DateTime.Now.Year;
                }
                    
                else
                    year = value;
            }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}",day,month,year);
        }

        #endregion
    }
}
