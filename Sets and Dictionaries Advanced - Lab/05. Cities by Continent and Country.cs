int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> dictionary = new();
for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = tokens[0];
    string country = tokens[1];
    string city = tokens[2];
    if (dictionary.ContainsKey(continent))
    {
        if (dictionary[continent].ContainsKey(country))
        {
            dictionary[continent][country].Add(city);
        }
        else
        {
            dictionary[continent].Add(country, new List<string> { city });
        }
    }
    else
    {
        dictionary.Add(continent, new());
        dictionary[continent].Add(country, new List<string> { city });
    }
}
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}:");
    foreach (var pair in item.Value)
    {
        Console.WriteLine($"{pair.Key} -> {string.Join(", ", pair.Value)}");
    }
}