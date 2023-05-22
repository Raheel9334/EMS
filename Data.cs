using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    class Data
    {
        public static List<Employee> employees = new List<Employee>(); 

        
    }
    class PayrolData
    {

        public static List<Payroll> payrolls = new List<Payroll>();
    }
    class GFG : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method
            return x.CompareTo(y);

        }
    }
}
