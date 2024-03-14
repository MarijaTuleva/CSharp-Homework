

Console.WriteLine("\n======== Exercise06 ========\n");

string[] names = new string[1];


Console.Write("Enter a name: ");
string name = Console.ReadLine();
names[0] = name;

Console.Write("(Write either Y or N)\nWould you like to enter another name: ");
string yesOrNo = Console.ReadLine();

if (yesOrNo == "Y")
{
    while (true)
    {
        Console.Write("Enter another name: ");
        string anotherName = Console.ReadLine();

        Array.Resize(ref names, names.Length + 1);
        names[names.Length - 1] = anotherName;

        if (anotherName == "N")
        {
            foreach (string oneName in names)
            {
                Console.WriteLine($"{oneName }");

            }
            break;

        }



    }
}

else if (yesOrNo == "N")
{
    foreach (string oneName in names)
    {
        Console.WriteLine($"{oneName}");
        
    }
}

else
{
    Console.WriteLine("Please enter either Y or N.");
}





Console.ReadLine();




