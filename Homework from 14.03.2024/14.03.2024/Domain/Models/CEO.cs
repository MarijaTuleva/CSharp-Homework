using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employees, int sharesproperty, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Employees = employees;
            SharesProperty = sharesproperty;
            Salary = salary;
            

        }


        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }

        public void PrintEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }

        public override double GetSalary()
        {
            Salary = Salary + SharesProperty * SharesPrice;
            return Salary;
        }
    }
}


    
