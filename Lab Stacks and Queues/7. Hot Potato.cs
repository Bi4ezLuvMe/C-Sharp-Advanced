string[] names = Console.ReadLine().Split().ToArray();
int n = int.Parse(Console.ReadLine());  
Queue<string> queue = new Queue<string>(names);
while(queue.Count > 0)
{
	if(queue.Count == 1)
	{
        string name1 = queue.Peek();
        Console.WriteLine($"Last is {name1}");
		break;
    }
	for (int i = 1; i < n; i++)
	{
		string currName = queue.Peek();
		queue.Dequeue();
		queue.Enqueue(currName);
	}
	string name = queue.Peek();
    Console.WriteLine($"Removed {name}");
	queue.Dequeue();
}