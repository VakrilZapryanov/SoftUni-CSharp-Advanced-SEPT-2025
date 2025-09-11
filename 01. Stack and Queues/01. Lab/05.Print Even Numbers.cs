int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var queue = new Queue<int>(numbers);
List<int> result = new();

while (queue.Count > 0)
{
    int number = queue.Dequeue();

    if (number % 2 == 0)
    {
        result.Add(number);
    }
}

Console.WriteLine(string.Join(", ", result));