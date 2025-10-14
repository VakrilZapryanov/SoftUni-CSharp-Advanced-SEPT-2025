SortedDictionary<string, Dictionary<string, double>> stores = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Revision")
{
    string[] arguments = command.Split(", ");

    string shopName = arguments[0];
    string product = arguments[1];
    double productPrice = double.Parse(arguments[2]);

    if (!stores.ContainsKey(shopName))
        stores[shopName] = new Dictionary<string, double>();

    stores[shopName][product] = productPrice;
}

foreach (var (store, products) in stores)
{
    Console.WriteLine(store + "->");

    foreach (var (product, price) in products)
        Console.WriteLine($"Product: {product}, Price: {price}");
}