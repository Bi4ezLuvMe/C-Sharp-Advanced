int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string type =  Console.ReadLine();
switch (type)
{
    case "even":
        for (int i = numbers[0]; i <= numbers[1]; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i+" ");
            }
        }break;
    case "odd":
        for (int i = numbers[0]; i <= numbers[1]; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i+  " ");
            }
        }
        break;
}