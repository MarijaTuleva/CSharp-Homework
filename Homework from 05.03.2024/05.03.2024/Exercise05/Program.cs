
Console.WriteLine("\n======== Exercise05 ========\n");

int[] array = new int[5];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Enter a number: ");

    string input = Console.ReadLine();

    bool isParsed = int.TryParse(input, out int parsed);

    if (isParsed)
    {
        array[i] = parsed;
    }

    else
    {
        Console.WriteLine("You've entered an invalid number!");
        break;
    }

    sum = sum + parsed;

}


Console.WriteLine($"\nThe sum of the numbers is {sum}.\n");





