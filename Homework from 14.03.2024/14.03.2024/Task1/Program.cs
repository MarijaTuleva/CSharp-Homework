

using Domain.Enums;
using Domain.Models;
using System.Data;

Employee employee1 = new Employee()
{
    FirstName = "Zlatko",
    LastName = "Zlatev",
    Role = Role.Other
};

Employee employee2 = new Employee()
{
    FirstName = "Ivan",
    LastName = "Ivanovski",
    Role = Role.Other
};

Employee employee3 = new Employee()
{
    FirstName = "Ana",
    LastName = "Aneva",
    Role = Role.Other
};

employee1.PrintInfo();
employee2.PrintInfo();
employee3.PrintInfo();

Manager manager = new Manager("Elon", "Mask", 200);
manager.PrintInfo();
manager.AddBonus(100);
manager.PrintInfo();


Contractor contractor = new Contractor("David", "Davidovski", 8, 27, manager);
contractor.PrintInfo();

string position = contractor.CurrentPosition();
Console.WriteLine(position);

