using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Employees
    {
        public string employees { get; set;}
        public int employees_salary { get; set; }
        public string employees_position { get; set; }
        public int employees_age { get; set; }
        public Employees(string employee,string position,int salary,int age)
        {
            this.employees = employee;
            this.employees_salary = salary;
            this.employees_position = position;
            this.employees_age = age;
        }
        public override string ToString()
        {
            if (this.employees.Contains("dayofpay"))
            {
                JobPositions.getBoss = employees;
                Console.WriteLine(employees + "is the boss");
            }
            return $"Employee : {this.employees} Position: {this.employees_position} now receives {this.employees_salary:f2} leva.";
        }
    }
}
