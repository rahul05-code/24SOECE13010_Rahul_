using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    class Employee1
    {
        int emp_code;
        string emp_name;
        string emp_designation;
        string instname;
        int basicpay;

        public void Emp_Details(int emp_code,string emp_name,string emp_designation,string instname,int basicpay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.emp_designation = emp_designation;
            this.instname = instname;
            this.basicpay = basicpay;
        }

        public void show_Details()
        {
            Console.WriteLine("Employee Code:" + emp_code);
            Console.WriteLine("Employee Name:"+emp_name);
            Console.WriteLine("Designation:"+emp_designation);
            Console.WriteLine("Institute:"+instname);
            Console.WriteLine("Basic Pay:"+basicpay);
        }


    }
    internal class example
    {
        public static void Main(string[] args)
        {
            Employee1 emp = new Employee1();

            emp.Emp_Details(1, "rk", "hod", "rku", 50);
            emp.show_Details();
        }
    }
}
