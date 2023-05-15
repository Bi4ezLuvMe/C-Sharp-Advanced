int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackSize = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>(clothes);
int rackCount = 1;
int sum = rackSize;
while(stack.Count > 0)
{
    sum-=stack.Peek();
    if (sum < 0)
    {
        sum = rackSize;
        rackCount++;
        continue;
    }
    stack.Pop();
}
Console.WriteLine(rackCount);
