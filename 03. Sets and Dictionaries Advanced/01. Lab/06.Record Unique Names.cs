int namesCount = int.Parse(Console.ReadLine());

HashSet<string> uniqueNames = new();

for (int i = 0; i < namesCount; i++)
{
    string name = Console.ReadLine();

    uniqueNames.Add(name);
}

foreach (var name in uniqueNames)
    Console.WriteLine(name);
