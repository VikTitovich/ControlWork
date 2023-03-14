int ReadInt(string argument)
{
    Console.Write(argument);

    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
    return number;
}

string ReadString(string argument)
{
    Console.Write(argument);

    string? line = Console.ReadLine();

    return line!;
}
