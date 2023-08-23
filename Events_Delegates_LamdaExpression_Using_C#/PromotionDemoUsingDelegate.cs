using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_LamdaExpression_Using_C_
{

    public delegate bool EligibleToPromote(Employee EmployeeToPromotion);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees,EligibleToPromote IseligibleToPromote)
        {
            foreach(Employee employee in employees)
            {
                if (IseligibleToPromote(employee))
                {
                    Console.WriteLine($"Employee {employee.Name} Promoted");
                    employee.Salary+=(int)(employee.Salary * 0.1);
                    Console.WriteLine($"Present salary after promotion is {employee.Salary}");

                }
            }
        }


    }
    public class Program
    {
        static void Main5()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);
            EligibleToPromote eligibleTopromote = new EligibleToPromote(Program.Promote);
            Employee.PromoteEmployee(lstEmployess, eligibleTopromote);
            Console.ReadKey();
            // Employee.PromoteEmployee(lstEmployess, x => x.Experience > 5);
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
