
Console.WriteLine("\n======== Task1 ========\n");

int[] array = new int[6];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter integer number: ");

    string input = Console.ReadLine();

    bool isParsed = int.TryParse(input, out int parsed);

    if (isParsed)
    {
        if (parsed % 2 == 0)
        {
            sum = sum + parsed;
   
        }

    }
    else
    {
        Console.WriteLine("You've entered an invalid number!");
        break;

    }


}

Console.WriteLine($"\nThe result is: {sum}\n");



Console.ReadLine();
