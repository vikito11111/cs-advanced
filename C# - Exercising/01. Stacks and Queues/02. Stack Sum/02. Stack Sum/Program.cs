Console.WriteLine("Write an input of integer numbers.");
int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var stackSum = 0;

var stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    stack.Push(input[i]);
}

var commandInput = "";

while ((commandInput = Console.ReadLine()) != "end")
{
    var commandTokens = commandInput.Split(" ");
    var command = commandTokens[0];

    if (command.Equals("add", StringComparison.CurrentCultureIgnoreCase))
    {
        int firstNumberToAdd = int.Parse(commandTokens[1]);
        int secondNumberToAdd = int.Parse(commandTokens[2]);

        stack.Push(firstNumberToAdd);
        stack.Push(secondNumberToAdd);
    }
    else if (command.Equals("remove", StringComparison.CurrentCultureIgnoreCase))
    {
        int numbersToRemove = int.Parse(commandTokens[1]);

        if (stack.Count < numbersToRemove)
        {
            continue;
        }
        else
        {
            for (int i = 0; i < numbersToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}

foreach (int number in stack)
{
    stackSum += number;
}

Console.WriteLine(stackSum);