var input = Console.ReadLine()
    .Split(separator: new[] { ", " }, options: StringSplitOptions.RemoveEmptyEntries)
    .Select(Parse)
    .ToList();

Console.WriteLine(input.Count());
Console.WriteLine(input.Sum());

static int Parse(string str)
{
    int number = 0;

    foreach (char c in str)
    {
        number *= 10;
        number += c - 48;
    }

    return number;
}