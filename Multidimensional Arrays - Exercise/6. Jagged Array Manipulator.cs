int n = int.Parse(Console.ReadLine());
double[][] array = new double[n][];
for (int i = 0; i < n; i++)
{
    double[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    array[i] = numbers;
}
for (int i = 0; i < n - 1; i++)
{
    if (array[i].Length == array[i + 1].Length)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            array[i][j] *= 2.00;
            array[i + 1][j] *= 2.00;
        }
    }
    else
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            array[i][j] /= 2.00;
        }
        for (int j = 0; j < array[i + 1].Length; j++)
        {
            array[i + 1][j] /= 2.00;
        }
    }
}
string command = Console.ReadLine();
while (command != "End")
{
    string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    if (tokens.Length == 4 && int.TryParse(tokens[1],out int row) ==true&& int.TryParse(tokens[2], out int col) == true && int.TryParse(tokens[3], out int value) == true )
    {
         row = int.Parse(tokens[1]);
         col = int.Parse(tokens[2]);
         value = int.Parse(tokens[3]);
        if (isValid(row, col))
        {
            if (tokens[0] == "Add")
            {
                array[row][col] += value;
            }
            else if (tokens[0] == "Subtract")
            {
                array[row][col] -= value;
            }
        }
    }
    command = Console.ReadLine();
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine(string.Join(" ", array[i]));
}

bool isValid(int row, int col)
{

    if (row < 0 || col < 0 || col > array[row].Length-1 || row > array.Length-1)
    {
        return false;
    }
    return true;
}