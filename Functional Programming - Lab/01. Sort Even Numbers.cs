namespace kure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            Array.Sort(temp);
            Console.WriteLine(String.Join(", ", temp));
        }
    }
}