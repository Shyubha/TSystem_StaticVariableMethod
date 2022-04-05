using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_StaticVariableMethod
{
    public class Employee
    {

        static int count;
        private int empid;
        private string name;
        private string address;

        public Employee(string name, string address)
        {

            count++;
            empid = count;
            this.name = name;
            this.address = address;

            this.address = address;



        }
        public static int GetCount()
        {
            return count;


        }



        public string GetData()
        {
            return "emp_id" + empid + "empname" + name + "empaddress" + address;

        }

    }
}
