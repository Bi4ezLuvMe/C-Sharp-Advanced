int[]tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = tokens[0];
int m = tokens[1];
HashSet<int> setN = new HashSet<int>();
HashSet<int> setM = new HashSet<int>();
for (int i = 0; i < n; i++)
{
    int curr = int.Parse(Console.ReadLine());
    setN.Add(curr);
}
for (int i = 0; i < m; i++)
{
    int curr = int.Parse(Console.ReadLine());
    setM.Add(curr);
}
foreach (int i in setN)
{
    foreach (int j in setM)
    {
        if (i == j)
        {
            Console.Write($"{i} ");
        }
    }
}