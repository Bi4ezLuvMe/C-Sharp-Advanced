int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(numbers.Min());