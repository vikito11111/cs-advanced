var input = Console.ReadLine()
    .Split(separator: new[] { ", " }, options: StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
.Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToList();

Console.Write(string.Join(", ", input));