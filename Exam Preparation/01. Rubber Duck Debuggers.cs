List<int>time = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int>tasks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int vaderDuck = 0;
int thorDuck = 0;
int blueDuck = 0;
int yellowDuck = 0;
while (time.Count > 0)
{
    int sum = time[0] * tasks[tasks.Count - 1];
    if (sum > 240)
    {
        tasks[tasks.Count - 1] -= 2;
        int temp = time[0];
        time.RemoveAt(0);
        time.Add(temp);
    }
    else
    {
        if (sum <= 60)
        {
            vaderDuck++;
        }else if (sum <= 120)
        {
            thorDuck++;
        }else if (sum <= 180)
        {
            blueDuck++;
        }else if (sum <= 240)
        {
            yellowDuck++;
        }
        time.RemoveAt(0);
        tasks.RemoveAt(tasks.Count - 1);
    }
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {vaderDuck}");
Console.WriteLine($"Thor Ducky: {thorDuck}");
Console.WriteLine($"Big Blue Rubber Ducky: {blueDuck}");
Console.WriteLine($"Small Yellow Rubber Ducky: {yellowDuck}");