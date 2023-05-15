int n = int.Parse(Console.ReadLine());
int[][] array = new int[n][];
for (int i = 0; i < n; i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    array[i] = numbers;
}
string command = Console.ReadLine();
while (command != "END")
{
    string[] command1 = command.Split();
    int row = int.Parse(command1[1]);
    int col = int.Parse(command1[2]);
    int value = int.Parse(command1[3]);
    if (row < 0 || col < 0 || row >= n || col >= n)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        if (command1[0] == "Add")
        {
            array[row][col] += value;
        }
        else if (command1[0] == "Subtract")
        {
            array[row][col] -= value;
        }
    }
    command = Console.ReadLine();
}
foreach (int[] element in array)
{
    Console.WriteLine(string.Join(" ", element));
}