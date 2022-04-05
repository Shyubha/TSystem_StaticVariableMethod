using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_StaticVariableMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Shubhankar", "Solapur");
            Console.WriteLine((emp.GetData()));
            Console.WriteLine(emp.Get);
            Console.ReadLine();
        }
    }
}

