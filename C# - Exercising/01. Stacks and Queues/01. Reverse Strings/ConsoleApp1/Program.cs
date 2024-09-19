using System.Text;

Console.WriteLine("Write a string:");
string input = Console.ReadLine();

var charStack = new Stack<char>();

StringBuilder sb = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    charStack.Push(input[i]);
}

while (charStack.Count > 0)
{
    char symbol = charStack.Pop();
    sb.Append(symbol);
}

Console.WriteLine(sb);