// 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int ArrayMin(int[] array)
{
    int minItem = array[0];
    int minItemIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minItem)
        {
            minItem = array[i];
            minItemIndex = i;
        }
    }
    return minItemIndex;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}

int[] MatrixSumRow(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        sumArr[i] = sumRow;
    }
    return sumArr;
}

int[,] initMatrix = MatrixRnd(4, 4, 0, 100);
PrintMatrix(initMatrix);
int[] sumArray = MatrixSumRow(initMatrix);
PrintArray(sumArray);
int minimal = ArrayMin(sumArray) + 1;
Console.WriteLine($"Row with minimal sum is number {minimal}");
