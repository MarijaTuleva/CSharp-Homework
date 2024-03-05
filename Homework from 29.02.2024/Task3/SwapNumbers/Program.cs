// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Input the First number:");
int first = int.Parse(Console.ReadLine());  
Console.Write("Input the Second number:");
int second = int.Parse(Console.ReadLine());

int swapFirst = second;
int swapSecond = first;

Console.WriteLine("After swapping:");
Console.WriteLine("First Number: " + swapFirst);
Console.WriteLine("Second Number: " + swapSecond);

Console.ReadLine();
