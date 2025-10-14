double[] numbersInput = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> numbers = new();

foreach (var number in numbersInput)
{
    if (!numbers.ContainsKey(number))
        numbers[number] = 0;

    numbers[number]++;
}

foreach (var entry in numbers)
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
