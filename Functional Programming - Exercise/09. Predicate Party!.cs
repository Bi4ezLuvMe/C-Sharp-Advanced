using System;
List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string command = Console.ReadLine();
while (command != "Party!")
{
    if (command.StartsWith("Remove"))
    {
        string[] temp = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (temp[1] == "StartsWith")
        {
            string word = temp[2];
            people.RemoveAll(x => x.StartsWith(word));
        }
        else if (temp[1] == "EndsWith")
        {
            string word = temp[2];
            people.RemoveAll(x => x.EndsWith(word));
        }
        else if (temp[1] == "Length")
        {
            int lenght = int.Parse(temp[2]);
            people.RemoveAll(x => x.Length == lenght);
        }
    }
    else if (command.StartsWith("Double"))
    {
        string[] temp = command.Split();
        if (temp[1] == "StartsWith")
        {
            List<string> temp1 = new();
            string word = temp[2];
            temp1 = people.Where(x => x.StartsWith(word)).ToList();
            for (int i = 0; i < temp1.Count; i++)
            {
                if (temp1.Any())
                {
                    people.Insert(0, temp1.ElementAt(i));
                }

            }
        }
        else if (temp[1] == "EndsWith")
        {
            List<string> temp1 = new();
            string word = temp[2];
            temp1 = people.Where(x => x.EndsWith(word)).ToList();
            for (int i = 0; i < temp1.Count; i++)
            {
                if (temp1.Any())
                {
                    people.Insert(0, temp1.ElementAt(i));
                }
            }
        }
        else if (temp[1] == "Length")
        {
            int lenght = int.Parse(temp[2]);
            List<string> temp1 = new();
            temp1 = people.Where(x => x.Length == lenght).ToList();
            for (int i = 0; i < temp1.Count; i++)
            {
                if (temp1.Any())
                {
                    people.Insert(0, temp1.ElementAt(i));
                }
            }
        }
    }
    command = Console.ReadLine();
}
if (people.Any())
{
    Console.Write(string.Join(", ", people));
    Console.WriteLine($" are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
