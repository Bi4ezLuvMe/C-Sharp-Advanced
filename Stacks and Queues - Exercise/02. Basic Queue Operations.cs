int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numberOfElements = n[0];
int numberOfPops = n[1];
int number = n[2];
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(numbers);
for (int i = 0; i < numberOfPops; i++)
{
    queue.Dequeue();
}
if (queue.Count == 0)
{
    Console.WriteLine(0);
    return;
}
if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}