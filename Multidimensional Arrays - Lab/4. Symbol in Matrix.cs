int x = int.Parse(Console.ReadLine());
char[,]matrix = new char[x,x];
for (int i = 0; i < x; i++)
{
    string input = Console.ReadLine();
    char[] inputAsAnArray=new char[x];
    for (int k = 0; k < x; k++)
    {
        inputAsAnArray[k] = input[k];
    }
    for (int j = 0; j < x; j++)
    {
        matrix[i, j] = inputAsAnArray[j];
    }
}
char wantedSymbol = char.Parse(Console.ReadLine());
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < x; j++)
    {
        if (matrix[i, j] == wantedSymbol)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{wantedSymbol} does not occur in the matrix");