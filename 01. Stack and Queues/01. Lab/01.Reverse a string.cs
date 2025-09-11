string text = Console.ReadLine();

Stack<char> stack = new(text);

while (stack.Count > 0)
{
    var symbol = stack.Pop();
    Console.Write(symbol);
}
