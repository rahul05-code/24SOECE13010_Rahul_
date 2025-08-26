using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    public static class Demo3
    {
        static int x = 10;

        static Demo3()
        {
            Console.WriteLine("Static class called!");
        }

        public static void show()
        {
            Console.WriteLine("X is:"+x);
        }

    }
    internal class static_class
    {
        static void Main(string[] args)
        {
            Demo3.show();
        }

    }
}
