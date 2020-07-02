using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGen
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 10, FirstName = "Darlene", LastName = "Smith", Gender = "Female", AnnualSalary = 60000
                },
                new Employee
                {
                EmployeeId = 11, FirstName = "Ashley", LastName = "Johnson", Gender = "Female", AnnualSalary = 40000},

                new Employee
                {
                    EmployeeId = 12, FirstName = "Donna", LastName = "Middle", Gender = "Female", AnnualSalary = 44000},

                new Employee
                {
                    EmployeeId = 13, FirstName = "Angela", LastName = "Parker", Gender = "Female", AnnualSalary = 69000},

                new Employee
                {
                    EmployeeId = 10, FirstName = "Bradley", LastName = "Jacobs", Gender = "Male", AnnualSalary = 60000},

                new Employee
                {
                    EmployeeId = 10, FirstName = "Marcel", LastName = "Van Tonder", Gender = "Male", AnnualSalary = 60000},

                new Employee
                {
                    EmployeeId = 10, FirstName = "Andries", LastName = "Vissagie", Gender = "Male", AnnualSalary = 44500},

                new Employee
                {
                    EmployeeId = 10, FirstName = "Marlene", LastName = "Potgieter", Gender = "Female", AnnualSalary = 70000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Danny", LastName = "Margo", Gender = "Male", AnnualSalary = 35900},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Brandon", LastName = "Seychelles", Gender = "Male", AnnualSalary = 76000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Onolo", LastName = "Tlharantlhophe", Gender = "Male", AnnualSalary = 60000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Keneilwe", LastName = "Meetlo", Gender = "Female", AnnualSalary = 60000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Sharon", LastName = "Shuttle", Gender = "Female", AnnualSalary = 70000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Andrew", LastName = "Skhosana", Gender = "Male", AnnualSalary = 40000},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Molemo", LastName = "Kemolebagane", Gender = "Male", AnnualSalary = 50300},
                new Employee
                {
                    EmployeeId = 10, FirstName = "Kgosatsana", LastName = "Montshwanedi", Gender = "Female", AnnualSalary = 66000},
            };

            return ListEmployees;
        }
    }
}
