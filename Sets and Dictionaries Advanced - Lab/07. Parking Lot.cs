string command = Console.ReadLine();
HashSet<string> cars = new();
while (command != "END")
{
    string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string direction = tokens[0];
    string carNum = tokens[1];
    if (direction == "IN")
    {
        cars.Add(carNum);
    }
    else if (direction == "OUT")
    {
        cars.Remove(carNum);
    }
    command = Console.ReadLine();
}
if (cars.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, cars));
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}