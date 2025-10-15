int usernamesCount = int.Parse(Console.ReadLine());

HashSet<string> uniqueUsernames = new();
List<string> uniqueInsertOrder = new();

for (int i = 0; i < usernamesCount; i++)
{
    string currentUsername = Console.ReadLine();

    if (!uniqueUsernames.Contains(currentUsername))
    {
        uniqueUsernames.Add(currentUsername);
        uniqueInsertOrder.Add(currentUsername);
    }
}

foreach (var username in uniqueInsertOrder)
    Console.WriteLine(username);