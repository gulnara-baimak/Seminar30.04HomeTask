// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Исходный двумерный массив: ");
void FillArray(int[,] array2D) // метод заполнения массива
{
    for (int i = 0; i < array2D.GetLength(0); i++) // длина строки
    {
        for (int j = 0; j < array2D .GetLength(1); j++) // длина столбца
        {
            array2D [i, j] = new Random().Next(1, 10); // случайными числами заполняем массив
        }
    }
}
void PrintArray(int[,] array2D) // метод выведения массива в консоли
{
    for (int i = 0; i < array2D.GetLength(0); i++)  // цикл для строк матрицы
    {
        for (int j = 0; j < array2D.GetLength(1); j++)  // цикл для столбца матрицы
        {
            Console.Write($"{array2D[i, j]} "); // выводим в консоли
        }
        Console.WriteLine();
    }
}
void Decreasing(int[,] array2D) // метод по упорядочиванию на убывание элементов
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < array2D.GetLength(1) - j - 1; k++)   // цикл для сравнения и обмена
            {
                if (array2D[i, k] < array2D [i, k + 1])
                {
                    int t = array2D[i, k];  // обмен элементов
                    array2D[i, k] = array2D[i, k + 1];
                    array2D[i, k + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[7, 7];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Decreasing(matrix);
Console.WriteLine("Преобразованный двумерный массив: ");
PrintArray(matrix);