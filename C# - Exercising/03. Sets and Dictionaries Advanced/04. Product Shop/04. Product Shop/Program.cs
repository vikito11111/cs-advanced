var shopDictionary = new Dictionary<string, Dictionary<string, double>>();

string input;

while ((input = Console.ReadLine()) != "Revision")
{
    var inputTokens = input.Split(separator: new[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string shop = inputTokens[0];
    string product = inputTokens[1];
    double price = double.Parse(inputTokens[2]);

    if (shopDictionary.ContainsKey(shop))
    {
        shopDictionary[shop].Add(product, price);
    }
    else
    {
        shopDictionary.Add(shop, new Dictionary<string, double>());
        shopDictionary[shop].Add(product, price);
    }
}

foreach (var shop in shopDictionary.OrderBy(x => x.Key))
{
    Console.WriteLine($"{shop.Key}->");

    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}