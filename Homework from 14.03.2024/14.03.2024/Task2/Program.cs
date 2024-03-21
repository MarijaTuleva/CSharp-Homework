
using Domain.Enums;
using Domain.Models;



Manager manager1 = new Manager("Elon", "Mask", 200);
Manager manager2 = new Manager("Ella", "Musk", 300);

Contractor contractor1 = new Contractor("David", "Davidovski", 8, 27, manager1);
Contractor contractor2 = new Contractor("Mila", "Milevska", 9, 25, manager2);

SalesPerson salesperson = new SalesPerson("Kate", "Kiteva");


Employee[] company = new Employee[5];
company[0] = manager1;
company[1] = manager2;
company[2] = contractor1;
company[3] = contractor2;
company[4] = salesperson;


CEO ceoName = new CEO("Bob", "Bobyski", company, 4050, 8000);
ceoName.AddSharesPrice(3000);
Console.WriteLine("\nCEO:\n");
ceoName.PrintInfo();
Console.WriteLine("\nEmployees:\n");
ceoName.PrintEmployees();
ceoName.GetSalary();





