var input = Console.ReadLine()
    .Split(separator: new string[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

var rows = input[0];
var cols = input[1];

var matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    var matrixElementsInput = Console.ReadLine()
        .Split(separator: new string[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixElementsInput[col];
    }
}

int subMatrixRows = 2;

int subMatrixCols = 2;

if (rows < subMatrixRows || cols < subMatrixCols)
{
    Console.WriteLine("No solution!");

    return;
}

int maxMatrixSum = int.MinValue;
int maxSumRow = -1;
int maxSumCol = -1;

for (int row = 0; row <= rows - subMatrixRows; row++)
{
    for (int col = 0; col <= cols - subMatrixCols; col++)
    {
        var currentMatrixSum = 0;

        for (int subRow = 0; subRow < subMatrixRows; subRow++)
        {
            for (int subCol = 0; subCol < subMatrixCols; subCol++)
            {
                currentMatrixSum += matrix[row + subRow, col + subCol];
            }
        }

        if (currentMatrixSum > maxMatrixSum)
        {
            maxMatrixSum = currentMatrixSum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

for (int row = 0; row < subMatrixRows; row++)
{
    for (int col = 0; col < subMatrixCols; col++)
    {
        Console.Write(matrix[maxSumRow + row, maxSumCol + col] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(maxMatrixSum);