string input = Console.ReadLine();
SortedDictionary<char, int> counter = new();
for (int i = 0; i < input.Length; i++)
{
    if (counter.ContainsKey(input[i]))
    {
        counter[input[i]]++;
    }
    else
    {
        counter.Add(input[i], 1);
    }
}
foreach (var c in counter)
{
    Console.WriteLine($"{c.Key}: {c.Value} time/s");
}