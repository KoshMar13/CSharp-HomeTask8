// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System.Linq;

Console.Clear();

int[] UniqArray(int row)
{
    int[] array = new int[row];
    for (int i = 0; i < array.Length; i++)
    {
        int item = RandomValue();
        if (Array.IndexOf(array, item) != -1)
        {
            item = RandomValue();
            array[i] = item;
        }
        else
        {
            array[i] = item;
        }
    }
    return array;
}

int RandomValue()
{
    var rnd = new Random();
    int item = rnd.Next(10, 99);
    return item;
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
}

void Print3DArr(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(2); j++)
        {
            for (int k = 0; k < array3d.GetLength(1); k++)
            {
                Console.Write($"{array3d[i, j, k]}({i},{k},{j}) ");
            }
            Console.WriteLine();
        }
    }
}

// int[,,] Array3d(int[] array, int rows, int columns, int depths)
// {
//     int[,,] array3d = new int[rows, columns, depths];
//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//             {
//                 for (int l = 0; l < array.Length; l++)
//                 {
//                     array3d[i, j, k] = array[l];
//                 }
//             }
//         }
//     }
//     return array3d;
// }

int[,,] Array3d(int rows, int columns, int depths)
{
    int[,,] array3d = new int[rows, columns, depths];
    int[] array = UniqArray(rows * columns * depths);

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array3d.GetLength(0); j++)
        {
            for (int k = 0; k < array3d.GetLength(1); k++)
            {
                for (int l = 0; l < array3d.GetLength(2); l++)
                {
                    array3d[j, k, l] = array[i];
                }
            }
        }
    }
    return array3d;
}

Console.Write("Insert rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert depth: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[] arr = UniqArray(row * column * depth);
PrintArray(arr);
Console.WriteLine();
int[,,] arr3d = Array3d(row, column, depth);
Print3DArr(arr3d);
