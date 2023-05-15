int[]tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int sum = 0;
for (int i = 0; i < tokens[0]; i++)
{
    int[]matrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    sum += matrix.Sum();
}
Console.WriteLine(tokens[0]);
Console.WriteLine(tokens[1]);
Console.WriteLine(sum);
