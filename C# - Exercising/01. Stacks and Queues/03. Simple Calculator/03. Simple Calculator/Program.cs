using _03._Simple_Calculator;

Console.WriteLine("Write an input expression:");
var input = Console.ReadLine()
    .Split(" ")
    .ToArray();

CalculatorMethods calculator = new();

var sum = 0;

for (int i = 1; i < input.Length; i += 2)
{
    if (i == 1)
    {
        sum = calculator.CalculateFirstIteration(input, sum, i);
    }
    else
    {
        sum = calculator.Calculate(input, sum, i);
    }
}

Console.WriteLine($"The result is: {sum}");