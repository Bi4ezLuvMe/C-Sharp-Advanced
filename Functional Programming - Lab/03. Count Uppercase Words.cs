namespace kure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> IsUpper = w => Char.IsUpper(w[0]);
            string[] upperCase = words.Where(x => IsUpper(x)).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,upperCase));
        }
    }
}