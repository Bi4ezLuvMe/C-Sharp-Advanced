int n =int.Parse(Console.ReadLine());
HashSet<string> elements = new();
for (int i = 0; i < n; i++)
{
    string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	for (int j = 0; j < element.Length; j++)
	{
		elements.Add(element[j]);
	}
}
List<string>ordered = elements.OrderBy(x => x).ToList();
Console.WriteLine(string.Join(" ", ordered));