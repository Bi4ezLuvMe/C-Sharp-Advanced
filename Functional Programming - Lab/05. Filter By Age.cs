namespace kure
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                people.Add(tokens[0], int.Parse(tokens[1]));
            }
            string type=Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (type == "younger")
            {
                foreach (var item in people)
                {
                    if (item.Value > age)
                    {
                        people.Remove(item.Key);
                    }
                }
            }
            else
            {
                foreach (var item in people)
                {
                    if (item.Value < age)
                    {
                        people.Remove(item.Key);
                    }
                }
            }
            string format = Console.ReadLine();
            if(format == "name")
            {
                foreach (var item in people)
                {
                    Console.WriteLine(item.Key);
                }
            }else if(format == "age")
            {
                foreach (var item in people)
                {
                    Console.WriteLine(item.Value);
                }
            }
            else
            {
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}