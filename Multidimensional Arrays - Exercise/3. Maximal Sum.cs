using System.Runtime.InteropServices;

int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
int x = tokens[0];
int y = tokens[1];
int[,] matrix = new int[x, y];
int sum = 0;
for (int i = 0; i < x; i++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
int[] numbers1 = new int[9];
for (int i = 0; i < x - 2; i++)
{
    for (int j = 0; j < y - 2; j++)
    {
        if (Sum(matrix[i, j + 1],matrix[i + 1, j + 1],matrix[i + 1, j],matrix[i + 2, j],
            matrix[i + 2, j + 1],matrix[i + 2, j + 2],matrix[i + 1, j + 2],matrix[i, j],matrix[i, j + 2]) > sum)
        {
            sum = Sum(matrix[i, j + 1], matrix[i + 1, j + 1], matrix[i + 1, j], matrix[i + 2, j],
            matrix[i + 2, j + 1], matrix[i + 2, j + 2], matrix[i + 1, j + 2], matrix[i, j], matrix[i, j + 2]);
            Array(numbers1, matrix[i, j], matrix[i, j + 1], matrix[i, j + 2], matrix[i + 1, j], matrix[i + 1, j + 1],
                matrix[i + 1, j + 2], matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2]);
        }
    }
}
Console.WriteLine($"Sum = {sum}");
for (int i = 0; i < 9; i++)
{
    if (i == 2 || i == 5)
    {
        Console.WriteLine(numbers1[i]);
    }
    else
    {
        Console.Write($"{numbers1[i]} ");
    }
}
static void Array(int[]kur, int kur1, int kur2, int kur3, int kur4, int kur5, int kur6, int kur7, int kur8, int kur9)
{
    kur[0] = kur1;
    kur[1] = kur2;
    kur[2] = kur3;
    kur[3] = kur4;
    kur[4] = kur5;
    kur[5] = kur6;
    kur[6] = kur7;
    kur[7] = kur8;
    kur[8] = kur9;
}
int Sum(int kur , int kur2, int kur3, int kur4, int kur5, int kur6, int kur7, int kur8, int kur9)
{
    return kur + kur2 + kur3 + kur4 + kur5 + kur6 + kur7 + kur8 + kur9;
}