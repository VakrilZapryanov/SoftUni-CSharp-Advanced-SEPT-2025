List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .OrderByDescending(num => num)
    .Take(3)
    .ToList();

Console.WriteLine(string.Join(" ", numbers));