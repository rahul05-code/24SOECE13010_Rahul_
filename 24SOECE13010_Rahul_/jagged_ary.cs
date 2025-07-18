using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class jagged_ary
    {
        public static void Main(string[] args)
        {
            int[][] jary = new int[5][];

            jary[0] = new int[1];
            jary[1] = new int[2];
            jary[2] = new int[3];
            jary[3] = new int[4];
            jary[4] = new int[5];

            Console.WriteLine("Enter jagged array elements:");

            for (int i = 0; i < jary.Length; i++)
            {
                for (int j = 0; j < jary[i].Length; j++)
                {
                    jary[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("jagged array is:");
            for(int i = 0;i < jary.Length; i++)
            {
                for(int j = 0;j < jary[i].Length; j++)
                {
                    Console.Write(jary[i][j]);
                }
                Console.WriteLine();
            }


        }
    }
}
