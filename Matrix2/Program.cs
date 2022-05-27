// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"Программа задает прямоугольный двумерный массив и находит строку с наименьшей суммой элементов: ");

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array2D) 
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}
int Sum(int[,] array2D)
{
    int sum = 0;
    int minSum = 0;
    int minValue = 0;
    for (int m = 0; m < array2D.GetLength(0); m++)
    {
        for (int n = 0; n < array2D.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += array2D[m, n];
                minSum += array2D[m, n]; 
            }
            else sum += array2D[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minValue = m;
        }
        sum = 0;
    }
    return minValue;
}
int[,] matrix = new int[4, 6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Cтрока двумерного массива с наименьшей суммой элементов: " + Sum(matrix)); 