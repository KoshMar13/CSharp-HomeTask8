// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] MatrixRnd(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int colums = matrix2.GetLength(1);
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return resultMatrix;
}

int[,] initMatrix1 = MatrixRnd(4, 4, 0, 100);
PrintMatrix(initMatrix1);
int[,] initMatrix2 = MatrixRnd(4, 4, 0, 100);
PrintMatrix(initMatrix2);

if (initMatrix1.GetLength(1) != initMatrix2.GetLength(0)) 
{
    Console.WriteLine("Quantity of columns in Matrix1 doesn't match quantity of rows in matrix2. Inserted matrixes can't be multiplyed")
}
else
{
    int[,] resMatrix = MatrixMultiply(initMatrix1, initMatrix2);
    PrintMatrix(resMatrix);
}