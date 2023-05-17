Dictionary<double,int>numbers = new Dictionary<double,int>();
double[]numbers1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
foreach (var number in numbers1)
{
    if (numbers.ContainsKey(number))
    {
        numbers[number]++;
    }
    else
    {
        numbers.Add(number, 1);
    }
}
foreach (var number in numbers)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}