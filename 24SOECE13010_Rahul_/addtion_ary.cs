using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class addtion_ary
    {
        static void Main(string[] args)
        {
            int[,] ary1 = new int[2,2];

            int[,] ary2 = new int[2,2];

            Console.WriteLine("Enter array 1 element:");

            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    ary1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter array 2 element:");

            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(1); j++)
                {
                    ary2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


        }
    }
}
