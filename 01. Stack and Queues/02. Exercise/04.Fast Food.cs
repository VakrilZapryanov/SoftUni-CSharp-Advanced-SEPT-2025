using System.Numerics;

int foodQuantity = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new(orders);

int biggestOrder = queue.Max();
Console.WriteLine(biggestOrder);

while (queue.Count != 0)
{
    int currentOrder = queue.Peek();

    if (foodQuantity >= currentOrder)
    {
        foodQuantity -= currentOrder;
        queue.Dequeue();
    }
    else
        break;
}

if (queue.Count == 0)
    Console.WriteLine("Orders complete");
else
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");

/*
348
20 54 30 16 7 9

499
57 45 62 70 33 90 88 76

 */