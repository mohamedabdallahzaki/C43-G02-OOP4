using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP4.Part_2
{
    class Duration
    {

        #region Attrributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion


        #region constructor
        public Duration()
        {
            Hours = Seconds = Minute = 0;
        }

        public Duration(int num)
        {
            Hours = Minute = Seconds = num;
        }

        public Duration(int hour, int minute, int seconds)
        {
            Hours = hours;
            Minute = minutes;
            Seconds = seconds;
        }


        #endregion

        #region prop

        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                while (seconds >= 60)
                {
                    
                    minutes = seconds / 60; ;
                    seconds %= 60;
                }
            }
        }

        public int Minute
        {
            get { return minutes; }
            set
            {

                minutes = value;
                while (minutes >= 60)
                {
                    
                    hours = minutes / 60;
                    minutes %= 60;
                }
            }


        }


        public int Hours
        {
            get { return hours; }
            set
            {
                if (value <= 24 )
                hours = value;
                else 
                hours = 0;
            }
        }

        #endregion


     


        #region override
        public override string ToString()
        {
            if (hours > 0)
                return $"Hours: {Hours}, Minutes: {Minute}, Seconds: {Seconds}";
            else if (minutes > 0)
                return $"Minutes: {Minute}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";

        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 111010101 | 1111111; ;
        }
        #endregion











    }
}
