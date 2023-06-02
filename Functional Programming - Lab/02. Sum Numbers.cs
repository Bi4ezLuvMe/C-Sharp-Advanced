namespace kure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(temp.Length);
            Console.WriteLine(temp.Sum());
        }
    }
}