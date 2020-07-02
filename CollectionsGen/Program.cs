using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGen
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> result =Employee.GetAllEmployees(); 

            foreach(var emp in result)
                Console.WriteLine(emp.Gender +"\t" + emp.FirstName + "\t" + emp.LastName +"\t" + emp.AnnualSalary);
        }
    }
}
