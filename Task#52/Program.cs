// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[5, 5];
Random rand = new Random();
Console.WriteLine("Input array rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Array");
Console.WriteLine();


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Number columns array '{array.GetLength(1)}'");
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{sum / array.GetLength(0)}\t");
}
Console.Write(" <= Arithmetic average of each column in the array");
