int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[]sorted = numbers.OrderByDescending(x => x).ToArray();
if(sorted.Length == 1)
{
    Console.WriteLine(sorted[0]);
}else if(sorted.Length == 2)
{
    Console.WriteLine($"{sorted[0]} {sorted[1]}");
}
else
{
    Console.WriteLine($"{sorted[0]} {sorted[1]} {sorted[2]}");
}