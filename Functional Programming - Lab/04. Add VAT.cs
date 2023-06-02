namespace kure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] price = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2).ToArray();
            foreach (var item in price)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}