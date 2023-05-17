int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
int x = tokens[0];
int y = tokens[1];
char[,] matrix = new char[x, y];
int count = 0;
for (int i = 0; i < x; i++)
{
    char[] symbols = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = symbols[j];
    }
}
for (int i = 0; i < x - 1; i++)
{
    for (int j = 0; j < y - 1; j++)
    {
        char ch = matrix[i, j];
        if (matrix[i, j + 1] == ch && matrix[i + 1, j + 1] == ch && matrix[i + 1, j] == ch)
        {
            count++;
        }
    }
}
Console.WriteLine(count);