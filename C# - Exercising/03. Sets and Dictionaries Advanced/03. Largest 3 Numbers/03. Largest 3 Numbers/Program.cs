using System.Text;

var input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

input = input.OrderByDescending(x => x)
    .ToArray();

StringBuilder sb = new StringBuilder();

if (input.Length < 3)
{
    Console.WriteLine(string.Join(" ", input));
}
else
{
    for (int i = 0; i < 3; i++)
    {
        sb.Append(input[i] + " ");
    }

    Console.WriteLine(sb.ToString().TrimEnd());
}