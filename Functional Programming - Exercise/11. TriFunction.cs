int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
char[] currName;
for (int i = 0; i < names.Length; i++)
{
	currName = names[i].ToCharArray();
	int sum = 0;
	for (int j = 0; j < currName.Length; j++)
	{
		sum += currName[j];
	}
	if (sum >= n)
	{
		Console.WriteLine(names[i]);
		return; 
	}
}