using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{

    class Time
    {

        int hour;
        int minute;
        int second;
        public void setTime(int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void getTime()
        {
            Console.WriteLine("${0}:${1}:${2}"+hour,minute,second);
        }

    }

    class timeDisplay
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.setTime(11,35,00);
            t1.getTime();
        }
    }
}
