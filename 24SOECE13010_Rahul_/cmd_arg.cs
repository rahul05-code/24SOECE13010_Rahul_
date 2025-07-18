using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{
    internal class cmd_arg
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command Line Argument:");
            Console.WriteLine("First argument:"+args[0]);
            Console.WriteLine("Second argument:" + args[1]);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("argument:"+args[i]);
            }
        }
    }
}
