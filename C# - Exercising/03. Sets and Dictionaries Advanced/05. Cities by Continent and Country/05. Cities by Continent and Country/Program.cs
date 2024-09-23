using _05._Cities_by_Continent_and_Country;

var rand = new Random();

var continents = new Dictionary<string, Dictionary<string, List<City>>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine();
    var parts = line.Split(' ');

    var continentName = parts[0];
    var countryName = parts[1];
    var cityName = parts[2];

    if (!continents.ContainsKey(continentName))
    {
        continents.Add(continentName, new Dictionary<string, List<City>>());
    }

    var continent = continents[continentName];

    if (!continent.ContainsKey(countryName))
    {
        continent.Add(countryName, new List<City>());
    }

    var country = continent[countryName];

    if (country.Any(x => x.Name == cityName))
    {
        var city = country.FirstOrDefault(x => x.Name == cityName);

        city.Population += rand.Next(1000000, 20000000);
    }
    else
    {
        var city = new City();

        city.Name = cityName;

        city.Population = rand.Next(1000000, 20000000);

        country.Add(city);
    }

}

foreach (var continent in continents)
{
    Console.WriteLine(continent.Key + ":");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value.Select(x => x.Name))} -> {string.Join(", ", country.Value.Select(x => x.Population))}");
    }
}