HashSet<string> set = new();
int n =int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    set.Add(name);
}
Console.WriteLine(string.Join(Environment.NewLine,set));