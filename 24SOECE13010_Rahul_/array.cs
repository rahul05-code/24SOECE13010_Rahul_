using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class array
    {
        static void Main(string[] args)
        {
            //int[] a1 = new int[5];

            //int[] a1 = {1,2,3,4,5};//declaration of array

            int[] ary = new int[5];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());

            }
            
            

            //a1[0] = 1;
            //a1[1] = 2;
            //a1[2] = 3;
            //a1[3] = 4;
            //a1[4] = 5;


            //Console.WriteLine(a1[0]);
            //Console.WriteLine(a1[1]);
            //Console.WriteLine(a1[2]);
            //Console.WriteLine(a1[3]);
            //Console.WriteLine(a1[4]);

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}

            //foreach(int i in ary)
            //{
            //    Console.WriteLine(i);
            //}

            for(int i = 0;i < ary.Length; i++)
            {
                int sum = 0;
                sum += ary[i];
                //Console.WriteLine(sum);

                int avg = sum / ary.Length;
                Console.WriteLine(avg);
            }
            
            
            Console.ReadLine();





        }
    }
}
