// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter the first number: ");
double firstNum = double.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
double secondNum = double.Parse(Console.ReadLine());
Console.Write("Enter the operation: ");
string operation = Console.ReadLine();

double result;

switch (operation)
{
    case "+":
        result = firstNum + secondNum;
        Console.WriteLine("The result is " + result);
        break;
    case "-":
        result = firstNum - secondNum;
        Console.WriteLine("The result is " + result);
        break;
    case "*":
        result = firstNum * secondNum;
        Console.WriteLine("The result is " + result);
        break;
    case "/":
        result = firstNum / secondNum;
        Console.WriteLine("The result is " + result);
        break;

}


Console.ReadLine();
