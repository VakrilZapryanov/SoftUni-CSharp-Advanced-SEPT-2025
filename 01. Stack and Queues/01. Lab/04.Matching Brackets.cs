//Input
string expression = Console.ReadLine();

//Calculations
var stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    var symbol = expression[i];

    if (symbol == '(')
    {
        stack.Push(i);
    }
    else if (symbol == ')')
    {
        var openingBracketIndex = stack.Pop();
        var closingBracketIndex = i;

        var result = expression.Substring(openingBracketIndex,
            closingBracketIndex - openingBracketIndex + 1);

        //Output
        Console.WriteLine(result);
    }
}