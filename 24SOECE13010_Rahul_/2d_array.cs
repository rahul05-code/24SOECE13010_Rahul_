using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class _2d_array
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[2,2];
            //array[0,0] = 1;
            //array[0,1] = 2;
            //array[1,0] = 3;
            //array[1,1] = 4;

            //2 X 3 
            //int[,] ary = { { 1, 2 ,3 }, { 4, 5, 6 } };

            //for(int i = 0; i < ary.GetLength(0); i++)//for rows
            //{
            //    for(int j = 0; j < ary.GetLength(1); j++)//for columns
            //    {
            //        Console.Write(ary[i,j]);
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine(ary);

            //Console.WriteLine("First element:",ary[0,0]);
            //Console.WriteLine("Second element:", ary[0,1]);
            //Console.WriteLine("Third element:", ary[1,0]);
            //Console.WriteLine("Fourth element:", ary[1,1]);

            int[,] ary = new int[3, 3];
            Console.WriteLine("Enter elements of 3X3 array:");
            for(int i = 0; i < ary.GetLength(0); i++)
            {
                for(int j = 0; j < ary.GetLength(1); j++)
                {
                    ary[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}
