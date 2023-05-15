int x = int.Parse(Console.ReadLine());
int[,]matrix = new int[x,x];
for (int i = 0; i < x; i++)
{
    int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < x; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
int sum = 0;
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < x; j++)
    {
        if (i == j)
        {
            sum += matrix[i, j];
        }
    }
}
Console.WriteLine(sum);