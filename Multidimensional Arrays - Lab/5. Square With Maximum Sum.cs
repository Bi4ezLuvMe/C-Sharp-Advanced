int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int x = tokens[0];
int y = tokens[1];
int[,] matrix = new int[x, y];
for (int i = 0; i < x; i++)
{
    int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
int maxSum = 0;
int[] numbers1 = new int[4];
for (int i = 0; i < x - 1; i++)
{
    for (int j = 0; j < y - 1; j++)
    {
        if (matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1] > maxSum)
        {
            maxSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
            numbers1[0] = matrix[i, j];
            numbers1[1] = matrix[i, j + 1];
            numbers1[2] = matrix[i + 1, j];
            numbers1[3] = matrix[i + 1, j + 1];
        }
    }
}
Console.Write(numbers1[0] + " ");
Console.WriteLine(numbers1[1]);
Console.Write(numbers1[2] + " ");
Console.WriteLine(numbers1[3]);
Console.WriteLine(maxSum);