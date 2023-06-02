int n = int.Parse(Console.ReadLine());
Dictionary<int, int> counter = new();
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()) ;
    if (counter.ContainsKey(number))
    {
        counter[number]++;
    }
    else
    {
        counter.Add(number, 1);
    }
}
foreach (var item in counter)
{
    if (item.Value % 2 == 0)
    {
        Console.WriteLine(item.Key);
    }
}