string[] songs = Console.ReadLine().Split(", ");

Queue<string> queue = new(songs);

while (queue.Count != 0)
{
    string command = Console.ReadLine();

    if (command == "Play")
    {
        queue.Dequeue();
    }
    else if (command.StartsWith("Add"))
    {
        string songName = command.Substring(4);

        if (queue.Contains(songName))
            Console.WriteLine($"{songName} is already contained!");
        else
            queue.Enqueue(songName);
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", queue));
    }
}

Console.WriteLine("No more songs!");
