int[]numbers =Console.ReadLine().Split().Select(int.Parse).ToArray();
string command = Console.ReadLine().ToLower();
Stack<int> stack = new Stack<int>(numbers);
while (command != "end")
{
    if (command.StartsWith("add"))
    {
        string[]commandAsAnArray=command.Split();
        stack.Push(int.Parse(commandAsAnArray[1]));
        stack.Push(int.Parse(commandAsAnArray[2]));
    }
    else if (command.StartsWith("remove"))
    {
        string[] commandAsAnArray = command.Split();
        int number = int.Parse(commandAsAnArray[1]);
        if (number <= stack.Count)
        {
            for (int i = 0; i < number; i++)
            {
                stack.Pop();
            }
        }
    }
    command= Console.ReadLine().ToLower();
}
Console.WriteLine($"Sum: {stack.Sum()}");