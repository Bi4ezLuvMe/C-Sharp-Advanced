string input = Console.ReadLine();
Stack<int>indexes  = new Stack<int>();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexes.Push(i);
    }else if (input[i] == ')')
    {
        int indexOfOpenBrasket = indexes.Pop();
        string result = input.Substring(indexOfOpenBrasket,i-indexOfOpenBrasket+1);
        Console.WriteLine(result);
    }
}