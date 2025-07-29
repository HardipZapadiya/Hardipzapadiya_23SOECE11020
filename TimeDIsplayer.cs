using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardipzapadiya_23SOECE11020
{
    internal class TimeDIsplayer
    {
        int sec;
        int min;
        int hour;
        public TimeDIsplayer(int hour, int min, int sec)
        {
            this.sec = sec;
            this.min = min;
            this.hour = hour;
        }
        public int GetSec()
        {
            return sec;
        }
        public int GetMin()
        {
            return min;
        }
        public int GetHour()
        {
            return hour;
        }
        public void display()
        {
            System.Console.WriteLine(hour + ":" + min + ":" + sec);
        }

    }
}

