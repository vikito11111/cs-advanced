var firstInput = Console.ReadLine()
    .Split(separator: new string[] { ", " }, options: StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = firstInput[0];
int m = firstInput[1];

int[,] matrix = new int[n, m];

var matrixSum = 0;

for (int row = 0; row < n; row++)
{
    var secondInput = Console.ReadLine()
        .Split(separator: new string[] { ", " }, options: StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < m; col++)
    {
        matrix[row, col] = secondInput[col];
        matrixSum += secondInput[col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(matrixSum);

Console.ReadLine();