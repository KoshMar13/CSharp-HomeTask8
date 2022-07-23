// 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void MatrixSnail(int start, int[,] matrix, int row, int col) //Заполняет любую КВАДРАТНОЙ матрицы. Допилить до совсем любой не хватило терпения.
{
    if (matrix[row, col] == 0)
    {
        matrix[row, col] = start;
        start++;
        if (row <= col + 1 && row + col < matrix.GetLength(1) - 1)
        {
            MatrixSnail(start, matrix, row, col + 1);
        }
        else if (row < col && row + col >= matrix.GetLength(0) - 1)
        {
            MatrixSnail(start, matrix, row + 1, col);
        }
        else if (row >= col && row + col > matrix.GetLength(1) - 1)
        {
            MatrixSnail(start, matrix, row, col - 1);
        }
        else
        {
            MatrixSnail(start, matrix, row - 1, col);
        }
    }
}

// void MatrixSnail(int start, int[,] matrix, int row, int col) //Заполняет ЛЮБУЮ матрицу змейкой. Допилить до улитки не хватило терпения.
// {
//     if (matrix[row, col] == 0)
//     {
//         matrix[row, col] = start;
//         start++;
//         if (col < matrix.GetLength(1) - 1)
//         {
//             MatrixSnail(start, matrix, row, col + 1);
//         }
//         if (row < matrix.GetLength(0) - 1)
//         {
//             MatrixSnail(start, matrix, row + 1, col);
//         }
//         if (col > 0)
//         {
//             MatrixSnail(start, matrix, row, col - 1);
//         }
//         if (row > 0)
//         {
//             MatrixSnail(start, matrix, row - 1, col);
//         }
//     }
// }

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

Console.Clear();
int[,] matrix = new int[4, 4];
MatrixSnail(1, matrix, 0, 0);
PrintMatrix(matrix);
