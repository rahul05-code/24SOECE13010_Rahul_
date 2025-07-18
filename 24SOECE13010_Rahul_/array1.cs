using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class array1
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());

            }

            
            
        }
    }
}
