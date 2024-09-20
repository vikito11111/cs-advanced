int size = int.Parse(Console.ReadLine());

var matrix = new int[size, size];

var primaryMatrixDiagonalSum = 0;

for (int row = 0; row < size; row++)
{
    var matrixElementsInput = Console.ReadLine()
        .Split(separator: new string[] { " " }, StringSplitOptions.None)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = matrixElementsInput[col];
    }
}

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (row == col)
        {
            primaryMatrixDiagonalSum += matrix[row, col];
        }
    }
}

Console.WriteLine(primaryMatrixDiagonalSum);