int[] clothes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int OriginalRackCapacity = int.Parse(Console.ReadLine());

Stack<int> stack = new(clothes);

int rackCapacity = OriginalRackCapacity;
int rackCount = 1;

while (stack.Count != 0)
{
    int currentClothingCapacity = stack.Peek();

    if (rackCapacity < currentClothingCapacity)
    {
        rackCount++;
        rackCapacity = OriginalRackCapacity;
    }

    rackCapacity -= currentClothingCapacity;
    stack.Pop();
}

Console.WriteLine(rackCount);

