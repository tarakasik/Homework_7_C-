// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] myArray = new int[5, 5];
Random rand = new Random();
int positionRows = 0;
int positionColumns = 0;

void FindElement(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = rand.Next(1, 9);
            Console.Write($"{myArray[i, j]}\t");
            positionColumns++;
        }
        Console.WriteLine();
        positionRows++;
    }
}
Console.WriteLine("Input array rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FindElement(myArray);

if (rows <= positionRows && columns <= positionColumns)
{
    Console.WriteLine();
    Console.WriteLine($"Number : {myArray[rows - 1, columns - 1]}");
}
else
{
    Console.WriteLine("This element is missing in this array !!!");
}
