using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class freq_array
    {
        static void Main(string[] args)
        {
            int[] ary = new int[6];
            bool[] arr = new bool[ary.Length];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());

            }

            for (int i = 0;i < ary.Length; i++)
            {
                if (arr[i] == true)
                    continue;

                int cnt = 1;
                for (int j =i+1;j < ary.Length; j++)
                {
                    if (ary[i] == ary[j])
                    {
                        arr[i] = true;
                        cnt++;
                    }
                }
                Console.WriteLine("Frequency of {0} is {1} times",ary[i],cnt);
            }

        }
    }
}
