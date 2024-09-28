var prices = Console.ReadLine()
    .Split(separator: new[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
    .Select(x => double.Parse(x) * 1.2);

foreach (var price in prices)
{
    Console.WriteLine($"{price:f2}");
}