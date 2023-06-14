int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split().Where(x => x.Length <= n).ToArray();
Console.WriteLine(string.Join(Environment.NewLine, names));