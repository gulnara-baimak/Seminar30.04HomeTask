//  Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Программа работает для квадратных массивов

DateTime dateTime = new DateTime(2022-05-27);
Console.WriteLine(dateTime);

void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m, n]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] arr) // заполняю массив
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
           arr[m, n] = new Random().Next(1, 10);
        }
    }
}
void Replacement(int[,] arr) // метод заменяющий массив 
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        int[,] nums = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                nums[m, n] = arr[m, n];
            }
        }
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                arr[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Replacement(matrix);
PrintArray(matrix);
Console.WriteLine(DateTime.Now);