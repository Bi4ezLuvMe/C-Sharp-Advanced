List<string> names = Console.ReadLine().Split().ToList();
string command = Console.ReadLine();
List<string> namesToRemove = new();
while (command != "Print")
{
    string[] commandAsAnArray = command.Split(";");
    List<string> temp = new();
    if (command.StartsWith("Add"))
    {
        string ch = commandAsAnArray[2];
        if (commandAsAnArray[1] == "Starts with")
        {
            temp = names.Where(x => x.StartsWith(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Add(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Ends with")
        {
            temp = names.Where(x => x.EndsWith(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Add(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Lenght")
        {
            int lenght = int.Parse(commandAsAnArray[2]);
            temp = names.Where(x => x.Length==lenght).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Add(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Contains")
        {
            temp = names.Where(x => x.Contains(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Add(temp.ElementAt(i));
            }
        }
    }
    else if (command.StartsWith("Remove"))
    {
        string ch = commandAsAnArray[2];
        if (commandAsAnArray[1] == "Starts with")
        {
            temp = names.Where(x => x.StartsWith(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Remove(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Ends with")
        {
            temp = names.Where(x => x.EndsWith(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Remove(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Lenght")
        {
            int lenght = int.Parse(commandAsAnArray[2]);
            temp = names.Where(x => x.Length == lenght).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Remove(temp.ElementAt(i));
            }
        }
        else if (commandAsAnArray[1] == "Contains")
        {
            temp = names.Where(x => x.Contains(ch)).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                namesToRemove.Remove(temp.ElementAt(i));
            }
        }
    }
    command = Console.ReadLine();
}
foreach (var item in namesToRemove)
{
    names.Remove(item);
}
Console.WriteLine(string.Join(" ", names));