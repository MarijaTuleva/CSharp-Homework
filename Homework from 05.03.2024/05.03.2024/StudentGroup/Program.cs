

Console.WriteLine("\n======== Task2 ========\n");

string[] studentsG1 = new string[] {"Olive", "Irma", "Colton", "Robby", "Antonia"};

string[] studentsG2 = new string[] {"Nikki", "Angie", "Rosetta", "Paul", "Rod"};

Console.Write("( there are 1 and 2 )\nEnter student group: ");

string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine("The students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine($"{student}");
    }
    
}

else if (input == "2")
{
    Console.WriteLine("The students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine($"{student}");
    }
}

else
{
    Console.WriteLine("Please input either 1 or 2.");
}

Console.ReadLine();