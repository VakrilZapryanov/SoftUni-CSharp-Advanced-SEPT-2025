var queue = new Queue<string>();
int counter = default;

string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
    if (command == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        counter = 0;
        continue;
    }

    string currentName = command;

    queue.Enqueue(currentName);
    counter++;
}

Console.WriteLine($"{counter} people remaining.");