using System;

int n = int.Parse(Console.ReadLine());

string text = string.Empty;

Stack<string> history = new();

for (int i = 1; i <= n; i++)
{
    string command = Console.ReadLine();

    if (command.StartsWith("1"))
    {
        history.Push(text);
        
        string textToAppend = command.Substring(2);
        text += textToAppend;
    }
    else if (command.StartsWith("2"))
    {
        history.Push(text);

        int symbolsToErase = int.Parse(command.Substring(2));
        text = text.Substring(0, text.Length - symbolsToErase);
    }
    else if (command.StartsWith("3"))
    {
        Console.WriteLine(text[int.Parse(command.Substring(2)) - 1]);
    }
    else if (command.StartsWith("4"))
    {
        text = history.Pop();
    }
}