﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class shorted_ary
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());

            }

            for (int i = 0;i < ary.Length; i++)
            {
                for (int j = 0;j < ary.Length; j++)
                {
                    if (ary[i] > ary[j])
                    {
                        int temp = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array element:");
            for(int i = 0;i < ary.Length;i++)
            {
                Console.WriteLine(ary[i]);
            }
        }
    }
}
