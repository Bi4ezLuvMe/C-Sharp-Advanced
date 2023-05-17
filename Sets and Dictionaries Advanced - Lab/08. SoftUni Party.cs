HashSet<string> guest = new();
HashSet<string> VIP = new();
string command = Console.ReadLine();

while (command != "PARTY")
{
    if (Char.IsDigit(command[0]))
    {
        VIP.Add(command);
    }
    else
    {
        guest.Add(command);
    }
    command = Console.ReadLine();
}
while (command != "END")
{
    if (Char.IsDigit(command[0]))
    {
        VIP.Remove(command);
    }
    else
    {
        guest.Remove(command);
    }
    command = Console.ReadLine();
}
Console.WriteLine(guest.Count + VIP.Count);
if (VIP.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, VIP));
}
if (guest.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, guest));
}