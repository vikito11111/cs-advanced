int size = int.Parse(Console.ReadLine());

var matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    var matrixElementsInput = Console.ReadLine()
        .ToCharArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = matrixElementsInput[col];
    }
}

var symbolToSearchFor = char.Parse(Console.ReadLine());

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == symbolToSearchFor)
        {
            Console.WriteLine($"({row}, {col})");

            return;
        }
    }
}

Console.WriteLine($"{symbolToSearchFor} does not occur in the matrix!");