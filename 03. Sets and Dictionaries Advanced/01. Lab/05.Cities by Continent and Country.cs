int inputCount = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents = new();

while (inputCount > 0)
{
    inputCount--;

    string[] information = Console.ReadLine().Split();

    string continent = information[0];
    string country = information[1];
    string city = information[2];

    if (!continents.ContainsKey(continent))
        continents[continent] = new Dictionary<string, List<string>>();

    if (!continents[continent].ContainsKey(country))
        continents[continent][country] = new List<string>();

    continents[continent][country].Add(city);

}

foreach (var (continent, countries) in continents)
{
    Console.WriteLine(continent + ":");

    foreach (var (country, cities) in countries)
        Console.WriteLine($"    {country} -> {string.Join(", ", cities)}");
}
