Random rand = new Random();
int[,] array = new int[5,5];
FillMatrix(array);
Console.WriteLine("My array:");
Console.Write("Input line: ");
int findRows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input column: ");
int findColumns = Convert.ToInt32(Console.ReadLine()) - 1;

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 15);
            Console.Write($"{array[i, j]}\t");
        }
    }Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // array[i, j] = rand.Next(1, 15);
        // Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
if (findRows < 0 | findRows > array.GetLength(0) - 1 | findColumns < 0 | findColumns > array.GetLength(1) - 1)
{
    Console.WriteLine("This element is mising in this array");
}
else
{
    Console.WriteLine("Element number array = {0}", array[findRows, findColumns]);
}
Console.ReadLine();


