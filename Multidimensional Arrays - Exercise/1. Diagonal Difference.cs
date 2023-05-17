int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += matrix[i, i];
}
int sum1 = 0;
int temp = 0;
for (int i = n - 1; i >= 0; i--)
{
    sum1 += matrix[i, temp++];
}
Console.WriteLine(Math.Abs(sum1 - sum));