int[]tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int x = tokens[0];
int y = tokens[1];
int[,]matrix = new int[x,y];
for (int i = 0; i < x; i++)
{
    int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < numbers.Length; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
int[] sums = new int[y];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        sums[j] += matrix[i, j];
    }
}
Console.WriteLine(string.Join(Environment.NewLine,sums));