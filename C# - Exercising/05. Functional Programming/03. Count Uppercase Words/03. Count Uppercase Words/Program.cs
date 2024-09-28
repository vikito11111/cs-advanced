Func<string, bool> operationUpperCase = x => x[0].ToString().ToUpper() == x[0].ToString();

var spliters = new char[] { ' ', ':', '!', '?', '.' };

var inputLine = Console.ReadLine()
    .Split(separator: new[] { " " }, options: StringSplitOptions.RemoveEmptyEntries)
    .Where(operationUpperCase);

Console.WriteLine(string.Join(Environment.NewLine, inputLine));