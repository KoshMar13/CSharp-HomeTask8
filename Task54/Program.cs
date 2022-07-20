// 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
}

// int[] ArrayBubbleSort(int[] array)
// {
//     for (int i = 0; i + 1 < array.Length; i++)
//     {
//         for (int j = 0; j + 1 < (array.Length - i); j++)
//         {
//             if (array[j + 1] > array[j])
//             {
//                 int temp = array[j + 1];
//                 array[j + 1] = array[j];
//                 array[j] = temp;
//             }
//         }
//     }
//     return array;
// }

int[,] MatrixRowsSortReverse(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j + 1 < matrix.GetLength(1); j++)
        {
            for (int l = 0; l + 1 < (matrix.GetLength(1) - j); l++)
            {
                if (matrix[i, l + 1] > matrix[i, l])
                {
                    int temp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] initMatrix = MatrixRnd(3, 5, 0, 100);
PrintMatrix(initMatrix);
Console.WriteLine();
int[,] sortedMatrix = MatrixRowsSortReverse(initMatrix);
PrintMatrix(sortedMatrix);
