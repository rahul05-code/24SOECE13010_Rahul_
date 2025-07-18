using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class array_search
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());

            }

            int searchele;
            Console.WriteLine("Enter element to search:");
            searchele = Convert.ToInt32(Console.ReadLine());

            int flag = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == searchele)
                {
                    flag = 1;
                    break;
                    
                }

                if (flag == 1)
                {
                    Console.WriteLine("Element is found");
                }
                else
                {
                    Console.WriteLine("Element not found");
                }
                

                }

            }
        }
    }

