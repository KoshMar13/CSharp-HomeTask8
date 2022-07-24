// 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

Console.Write("Insert natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int value = 1,
    blank,
    i,
    j;
Console.WriteLine("Pascal's triangle:");
for (i = 0; i < number; i++)
{
    for (blank = 1; blank <= number - i; blank++)
        Console.Write(" ");
    for (j = 0; j <= i; j++)
    {
        if (j == 0 || i == 0)
            value = 1;
        else
            value = value * (i - j + 1) / j;
        Console.Write(value + " ");
    }
    Console.WriteLine();
}
