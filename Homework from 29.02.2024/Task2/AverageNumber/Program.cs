// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the First number:");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the Second number:");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter the Third number:");
int third = int.Parse(Console.ReadLine());
Console.Write("Enter the Fourth number:");
int fourth = int.Parse(Console.ReadLine());

int average = (first + second + third + fourth) / 4;

Console.WriteLine("The average of " + first + ", " + second + ", " + third + " and " + fourth + " is: " + average);

Console.ReadLine(); 
