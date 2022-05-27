// Программа, которая заполняет матрицу случайными числами
// i - строки считает
// j - столбцы считает

void PrintArray(int[,] matrix)//  метод: выводим матрицу в консоли
{
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
        Console.Write($"{matrix[i, j]} "); // косноль: выводим на экран
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод: заполняем матрицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) // cтроки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            matr[i, j] = new Random().Next(1,10); // генератор случайных чисел
        }
        
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
Console.WriteLine(); 
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(); 