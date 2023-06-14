int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < n; i++)
{
    string temp1 = Console.ReadLine();
    char[] temp = temp1.ToCharArray();
    for (int j = 0; j < temp.Length; j++)
    {
        matrix[i, j] = temp[j];
    }
}
int x = 0;
int y = 0;
int nutz = 0;
bool isAll = false;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] == 's')
        {
            x = i;
            y = j;
        }
    }
}
for (int i = 0; i < command.Length; i++)
{
    if (command[i] == "up")
    {
        if (x - 1 < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x - 1, y] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x - 1, y] == 'h')
        {
            nutz++;
            if (nutz == 3)
            {
                isAll = true;
                break;
            }
            matrix[x - 1, y] = '*';
        }
        x--;
    }
    else if (command[i] == "down")
    {
        if (x + 1 > n - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x + 1, y] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x + 1, y] == 'h')
        {
            nutz++;
            if (nutz == 3)
            {
                isAll = true;
                break;
            }
            matrix[x + 1, y] = '*';
        }
        x++;
    }
    else if (command[i] == "left")
    {
        if (y - 1 < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x, y - 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x, y - 1] == 'h')
        {
            nutz++;
            if (nutz == 3)
            {
                isAll = true;
                break;
            }
            matrix[x, y - 1] = '*';
        }
        y--;
    }
    else if (command[i] == "right")
    {
        if (y + 1 > n - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x, y + 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {nutz}");
            return;
        }
        else if (matrix[x, y + 1] == 'h')
        {
            nutz++;
            if (nutz == 3)
            {
                isAll = true;
                break;
            }
            matrix[x, y + 1] = '*';
        }
        y++;
    }
}
if (isAll)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
    Console.WriteLine($"Hazelnuts collected: {nutz}");
}
else
{
    Console.WriteLine("There are more hazelnuts to collect.");
    Console.WriteLine($"Hazelnuts collected: {nutz}");
}