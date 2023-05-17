int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
int x = tokens[0];
int y = tokens[1];
string[,] matrix = new string[x, y];
for (int i = 0; i < x; i++)
{
    string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < y; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
string command = Console.ReadLine();
while (command != "END")
{
    string[] commandAsAnArray = command.Split();
    if (commandAsAnArray[0] == "swap"&&commandAsAnArray.Length==5)
    {
        int row1 = int.Parse(commandAsAnArray[1]);
        int col1 = int.Parse(commandAsAnArray[2]);
        int row2 = int.Parse(commandAsAnArray[3]);
        int col2 = int.Parse(commandAsAnArray[4]);
        if (isValid(row1, col1, row2, col2))
        {
            string number1 = string.Empty;
            string number2 = string.Empty;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == row1 && j == col1)
                    {
                        number1 = matrix[i, j];
                    }
                    if (i == row2 && j == col2)
                    {
                        number2 = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == row1 && j == col1)
                    {
                        matrix[i, j] = number2;
                    }
                    if (i == row2 && j == col2)
                    {
                        matrix[i, j] = number1;
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == y - 1)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine();
}

bool isValid(int row1, int col1, int row2, int col2)
{
    if (row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0 || row1 > x - 1 || row2 > x - 1 || col1 > y - 1 || col2 > y - 1)
    {
        return false;
    }
    return true;
}