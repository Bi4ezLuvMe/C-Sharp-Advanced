int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numberOfElements = n[0];
int numberOfPops = n[1];
int number = n[2];
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(numbers);
for (int i = 0; i < numberOfPops; i++)
{
    stack.Pop();
}
if (stack.Count == 0)
{
    Console.WriteLine(0);
    return;
}
if (stack.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}