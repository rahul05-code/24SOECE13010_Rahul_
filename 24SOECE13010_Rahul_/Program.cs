using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int no = 15;
            double temp = 32.45;
            char gender = 'm';
            string name;

            name = "RKU";

            Console.WriteLine(name);
            Console.WriteLine(temp);
            Console.WriteLine(gender);
            Console.WriteLine(no);

            string str;
            Console.WriteLine("Enter the string value:");
            str = Console.ReadLine();
            Console.WriteLine(str);
            int no1;
            no1 = 1;

            while (no1 <= 10)
            {
                Console.WriteLine(no1);
                no1++;
            }

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);

            }


            for (int i = 1; i <= 100; i++) {

                if (i % 0) {
                
                }
            
            
            }

            string str2, str3, str4;

            Console.WriteLine("Enter the first string:");
            str2 = Console.ReadLine();
            Console.WriteLine(str2);

            Console.WriteLine("Enter the second string");
            str3 = Console.ReadLine();
            int len = str3.Length;
            Console.WriteLine("Length of string 1 is:"+len);

            str4 = Console.ReadLine();  
            Console.WriteLine(str4);

            //combine the two strings
            string combinedString = str2 + " " + str3;
            Console.WriteLine("Combined String: " + combinedString);
            //convert to uppercase
            string upperString = combinedString.ToUpper();
            Console.WriteLine("Uppercase String: " + upperString);
            //interpolation of strings
            string interpolatedString = $"The combined string is: {combinedString} and its length is: {combinedString.Length}";












            Console.Read();
        }
    }
}
