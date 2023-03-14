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

void EnterArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadString($"Enter {i + 1} element: ");
    }
}

void GetArray(string[] array, string[] arrayNew)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];

            count++;
        }
    }
}