using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }


        public Contractor(string firstName, string lastName, double workHours, int payperhour, Manager responsible)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 0;
            WorkHours = workHours;
            PayPerHour = payperhour;
            Responsible = responsible;
            
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return $"The manager responsible for this contractor is in the {Responsible.Role} department.";
        }

    }
}
