Queue<string>songs = new(Console.ReadLine().Split(", ").ToArray());
string command = Console.ReadLine();
while (songs.Count > 0)
{
    if (command == "Play")
    {
        songs.Dequeue();
    }else if (command.StartsWith("Add"))
    {
        string[]commandAsAnArray = command.Split();
        string song=String.Empty;
        for (int i = 1; i < commandAsAnArray.Length; i++)
        {
            if (i == commandAsAnArray.Length - 1)
            {
                song += commandAsAnArray[i];
            }
            else
            {
                song += commandAsAnArray[i] + " ";
            }
        }
        
        if (songs.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songs.Enqueue(song);
        }
    }else if(command == "Show")
    {
        Console.WriteLine(string.Join(", ",songs));
    }
    command = Console.ReadLine();
}
Console.WriteLine("No more songs!");