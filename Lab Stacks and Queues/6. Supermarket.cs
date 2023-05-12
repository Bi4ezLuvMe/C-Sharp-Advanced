Queue<string> queue = new Queue<string>();
string command = Console.ReadLine();
while (command != "End")
{
    if (command != "Paid")
    {
        queue.Enqueue(command);
    }
    else
    {
        while(queue.Count > 0)
        {
            string name = queue.Peek();
            Console.WriteLine(name);
            queue.Dequeue();
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{queue.Count} people remaining.");