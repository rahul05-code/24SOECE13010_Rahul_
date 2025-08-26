using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    class Demo1
    {
        int x; //private member of class
        int y;

        public Demo1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            //set { x = value; }
            get { return x; }
        }
        public int Y
        {
            //set { y = value; } // initilize member
            get { return y; } //read-write properties
        }
    }
    internal class propertydemo
    {
        public static void Main(string[] args)
        {
            Demo1 demo = new Demo1(100,200);

            //demo.X = 100;
            //demo.Y = 200;

            Console.WriteLine(demo.X);
            Console.WriteLine(demo.Y);
        }
    }
}
