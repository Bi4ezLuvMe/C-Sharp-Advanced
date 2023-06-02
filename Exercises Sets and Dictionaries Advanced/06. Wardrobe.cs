int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> clothes = new();
for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" -> ");
    string[] tokens2 = tokens[1].Split(",");
    if (clothes.ContainsKey(tokens[0]))
    {
        for (int j = 0; j < tokens2.Length; j++)
        {
            clothes[tokens[0]].Add(tokens2[j]);
        }
    }
    else
    {
        clothes.Add(tokens[0], new List<string>(tokens2));
    }
}
string[] tokens1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string colour = tokens1[0];
string cloth = tokens1[1];
foreach (var item in clothes)
{
    Console.WriteLine($"{item.Key} clothes:");
    Dictionary<string, int> counter = new();
    foreach (var item1 in item.Value)
    {
        if (counter.ContainsKey(item1))
        {
            counter[item1]++;
        }
        else
        {
            counter.Add(item1, 1);
        }
    }
    foreach (var item2 in counter)
    {

        if (item.Key == colour && item2.Key == cloth)
        {
            Console.WriteLine($"* {item2.Key} - {counter[item2.Key]} (found!)");
        }
        else
        {
            Console.WriteLine($"* {item2.Key} - {counter[item2.Key]}");
        }
    }
}