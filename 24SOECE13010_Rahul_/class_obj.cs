using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{

    public class Employee
    {
        int empid;
        string name;
        double salary;
        public void getData(int empid,string name,double salary)
        {
            this.empid = empid;
            this.name = name;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Employee Id :" + empid);
            Console.WriteLine("Employee Name :"+name);
            Console.WriteLine("Salary :"+salary);
        }

        public double getSalary()
        {
            return this.salary;
        }
    }
    internal class class_obj
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getData(111,"Rahul",50000);
            e1.showData();

            Employee e2 = new Employee();
            e2.getData(112,"Hardik",100000);
            e2.showData();

            if(e1.getSalary() > e2.getSalary())
            {
                e1.showData();
            }
            else
            {
                e2.showData();
            }
        }

    }
}
