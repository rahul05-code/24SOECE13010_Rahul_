using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    class employee
    {
        int id;
        string name;
        int sal;
        public employee()
        {
            int id;
            string name;
            int sal;
        }
        public employee(int id, string name, int sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }
        public void showData()
        {
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Name :"+name);
            Console.WriteLine("Salary :"+sal);
        }
    }
    internal class cmdconst
    {

        public static void Main(string[] args)
        {
            int id = Convert.ToInt32(args[0]);
            string name = (string)args[1];
            string sal = (string)args[2];

            employee emp = new employee();
            emp.showData();
        }
    }
}
