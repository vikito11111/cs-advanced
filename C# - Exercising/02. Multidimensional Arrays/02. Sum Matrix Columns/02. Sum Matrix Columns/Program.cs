var matrixSizeInput = Console.ReadLine()
    .Split(separator: new string[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = matrixSizeInput[0];
int m = matrixSizeInput[1];

var matrix = new int[n, m];

FillMatrix(n, m, matrix);

PrintMatrixColsSums(m, n, matrix);

static void PrintMatrixColsSums(int m, int n, int[,] matrix)
{
    for (int col = 0; col < m; col++)
    {
        var colSum = 0;

        for (int row = 0; row < n; row++)
        {

            colSum += matrix[row, col];
        }

        Console.WriteLine(colSum);
    }
}

static void FillMatrix(int n, int m, int[,] matrix)
{
    for (int row = 0; row < n; row++)
    {
        var matrixElementsInput = Console.ReadLine()
            .Split(separator: " ")
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < m; col++)
        {
            matrix[row, col] = matrixElementsInput[col];
        }
    }
}