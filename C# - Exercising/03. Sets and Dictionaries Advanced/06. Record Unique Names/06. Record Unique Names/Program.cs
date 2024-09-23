int n = int.Parse(Console.ReadLine());

var hashSetNames = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    hashSetNames.Add(Console.ReadLine());
}

foreach (var name in hashSetNames)
{
    Console.WriteLine(name);
}