string word = Console.ReadLine();
Stack<char> ch = new Stack<char>(word);
foreach (char c in ch)
{
    Console.Write(c);
}