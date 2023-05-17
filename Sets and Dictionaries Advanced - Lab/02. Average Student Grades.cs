int number = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> students = new();
for (int i = 0; i < number; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];
    decimal grade = decimal.Parse(tokens[1]);
    if (students.ContainsKey(name))
    {
        students[name].Add(grade);
    }
    else
    {
        students.Add(name, new List<decimal> { grade });
    }
}
foreach(var student in students)
{
    Console.Write($"{student.Key} -> ");
    foreach (var item in student.Value)
    {
        Console.Write($"{item:f2} ");
    }
    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}    