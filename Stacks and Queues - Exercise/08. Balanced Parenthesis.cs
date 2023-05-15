string input = Console.ReadLine();
Stack<char> stack = new();
foreach (char c in input)
{
    switch (c)
    {
        case '{':
        case '[':
        case '(':
            stack.Push(c);
            break;
        case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}
Console.WriteLine("YES");