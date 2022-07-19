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

// int[,] MatrixRowsSortReverse(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int rowMax = matrix[i, 0];
//         int temp = matrix[i, 0];
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] > rowMax)
//             {
//                 temp = matrix[i, j];
//                 matrix[i, j] = rowMax;
//                 rowMax = temp;
//             }
//         }
//     }
//     return matrix;
// }

// int[,] initMatrix = MatrixRnd(4, 4, 0, 100);
// PrintMatrix(initMatrix);
// Console.WriteLine();
// int[,] sortedMatrix = MatrixRowsSortReverse(initMatrix);
// PrintMatrix(sortedMatrix);

int[] BubbleSort(int[] array)
{
    int rowMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] > rowMax)
            {
                int temp = array[i];
                array[i] = rowMax;
                array[i - 1] = temp;
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + "; ");
        else
            Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}

int[] NewArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] arr = NewArrayRnd(5, 0, 100);
PrintArray(arr);
Console.WriteLine();
int[] sortedArr = BubbleSort(arr);
PrintArray(sortedArr);
