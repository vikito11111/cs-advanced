var output = Console.ReadLine()
    .Split(' ')
    .Select(double.Parse)
    .ToArray();

var numberDictionary = new Dictionary<double, int>();

for (int i = 0; i < output.Length; i++)
{
    if (!(numberDictionary.ContainsKey(output[i])))
    {
        numberDictionary.Add(output[i], 0);
    }

    numberDictionary[output[i]]++;
}

foreach (var number in numberDictionary)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}