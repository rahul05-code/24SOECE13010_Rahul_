using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{

    class student
    {
        int id;
        string name;

        public student(student s)
        {
            this.id = s.id;
            this.name = s.name;
        }


        public student()
        {
            Console.WriteLine("Enter Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name = Convert.ToString(Console.ReadLine());
        }

        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void showdata()
        {
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Name:"+ name);
        }

    }
    internal class constructor
    {
        public static void Main(string[] args)
        {

            student []s = new student[5];
            student s1 = new student(1,"Rahul");
            s1.showdata();

            student s2 = new student(2, "Bansi");
            s2.showdata();

            student s3 = new student();
            s3.showdata();

            student s4 = new student(s3);
            s4.showdata();

            for (int i = 0;i < s.Length;i++)
            {
                s[i] = new student();
            }

            for(int i = 0; i < s.Length; i++)
            {
                s[i].showdata();
            }
        }
    }
}
