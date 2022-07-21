// 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void MatrixSnail(int start, int[,] matrix, int rowBegin, int colBegin)
{
    if (matrix[rowBegin, colBegin] == 0)
    {
        matrix[rowBegin, colBegin] = start;
        start++;
        if (colBegin < matrix.GetLength(1) - 1)
        {
            MatrixSnail(start, matrix, rowBegin, colBegin + 1);
        }
        else if (rowBegin < matrix.GetLength(0) - 1)
        {
            MatrixSnail(start, matrix, rowBegin + 1, colBegin);
        }
        else if (colBegin > 0)
        {
            MatrixSnail(start, matrix, rowBegin, colBegin - 1);
        }
        else if (rowBegin > 0)
        {
            MatrixSnail(start, matrix, rowBegin - 1, colBegin);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 3}| ");
            else
                Console.Write($"{matrix[i, j], 3}|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matrix = new int[4, 4];
MatrixSnail(1, matrix, 0, 0);
PrintMatrix(matrix);
