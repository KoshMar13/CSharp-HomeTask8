﻿// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
    }
    Console.WriteLine();
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int columns = matrix2.GetLength(1);
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] initMatrix1 = MatrixRnd(4, 2, 0, 10);
PrintMatrix(initMatrix1);
int[,] initMatrix2 = MatrixRnd(2, 3, 0, 10);
PrintMatrix(initMatrix2);

if (initMatrix1.GetLength(1) != initMatrix2.GetLength(0))
{
    Console.WriteLine("Quantity of columns in Matrix1 doesn't match quantity of rows in matrix2.");
    Console.WriteLine("Inserted matrixes can't be multiplyed.");
}
else
{
    int[,] resMatrix = MatrixMultiply(initMatrix1, initMatrix2);
    PrintMatrix(resMatrix);
}
