int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command = Console.ReadLine();
Func<int, int> add = x => x += 1;

Func<int, int> multiply = x => x *= 2;
Func<int, int> subtract = x => x -= 1;
while (command != "end")
{
    switch (command)
    {
        case "add":
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = add(numbers[i]);
            }
            break;
        case "subtract":
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = subtract(numbers[i]);
            }
            break;
        case "multiply":
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = multiply(numbers[i]);
            }
            break;
        case "print":
            Console.WriteLine(string.Join(" ", numbers));
            break;

    }
    command = Console.ReadLine();
}