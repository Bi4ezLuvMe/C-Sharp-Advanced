string[] input = Console.ReadLine().Split().ToArray();

Stack<string> stack = new Stack<string>(input);
int sum = 0;
int counter = 0;
int number = 0;
foreach (var c in stack)
{
    if (counter % 2 == 0)
    {
         number = int.Parse(c);
        counter++;
    }
    else
    {
        string sign = c;
        if(sign == "+")
        {
            sum += number;
        }
        else
        {
            sum-=number;
        }
        counter++;
    }
    
}
sum += number;
Console.WriteLine(sum);