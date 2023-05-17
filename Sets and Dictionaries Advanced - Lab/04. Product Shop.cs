using System.Xml;

SortedDictionary<string, Dictionary<string, double>> products = new();
string command = Console.ReadLine();
while(command!= "Revision")
{
    string[]tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);
    if (products.ContainsKey(shop))
    {
        products[shop].Add(product, price);
    }
    else
    {
        products.Add(shop,new Dictionary<string, double> ());
    }
    products[shop][product] = price;
    command = Console.ReadLine();
}
foreach (var item in products)
{
    Console.WriteLine($"{item.Key}->");
    foreach (var product in item.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}