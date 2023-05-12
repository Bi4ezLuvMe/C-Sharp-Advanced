int n =int.Parse(Console.ReadLine());
Queue<string>cars = new Queue<string>();
int count = 0;
string command = Console.ReadLine();
while (command != "end")
{
    if (command != "green")
    {
        cars.Enqueue(command);
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            if(cars.Count == 0) { break; }
            string currCar = cars.Peek();
            Console.WriteLine($"{currCar} passed!");
            cars.Dequeue();
            count++;
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{count} cars passed the crossroads.");