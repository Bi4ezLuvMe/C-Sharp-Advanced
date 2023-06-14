int[]numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
int n = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(" ",numbers.Where(x=>x%n!=0)));