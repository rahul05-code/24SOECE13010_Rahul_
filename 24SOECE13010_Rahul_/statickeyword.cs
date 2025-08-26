using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    public class Demo2
    {
        int x;
        public static int y=20;

        public Demo2(int x)
        {
            this.x = x;
        }

        public static int addNum()
        {
            Demo2 ob = new Demo2();
            return (ob.x + y);
        }

        public void show()
        {
            Console.WriteLine("X is :" + x);
            Console.WriteLine("Y is :"+ y);
        }
    }
    internal class statickeyword
    {
        public static void Main(string[] args)
        {
            Demo2 ob = new Demo2(30);
            Demo2.addNum();
            ob.show();

        }
    }
}
