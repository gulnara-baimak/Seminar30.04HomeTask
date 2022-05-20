// В двумерном массиве целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

Console.WriteLine("Программа, которая в двумерном массиве целых чисел удалит строку и столбец, на пересечении которых расположен наименьший элемент");

void PrintArray(int[,] array)//  метод: выводим матрицу в консоли
{
    for (int i = 0; i < 6; i++) // строки
    {
        for (int j = 0; j < 6; j++) // столбцы
        {
        Console.Write($"{array[i, j]} "); // косноль: выводим на экран
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

int k = 6;
int n = 6;
int[,] array = new int[k, n];
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine(); 

int x = 0; // переменная для хранения данных строки 
int y = 0; // переменная для хранения данных столбцов
int min = array[0, 0]; // ввожу переменную для хранения минимального значения в двумерном массиве
for (int i = 0; i < array.GetLength(0); i++) // перебираю строки
{
    for (int j = 0; j < array.GetLength(1); j++) //перебираю столбцы
    {
        if (array[i, j] < min) // если полученные значения меньше минимального
        {
            min = array[i, j]; // присваиваю минимальное текущим элементам массива
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент двумерного массива: " + min);

Console.WriteLine("Измененный массив после удаления: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y)) // рекурсия, если i равен х или j равен у то продолжаю
            continue;
            else Console.Write(array[i, j] + " "); // иначе вывожу двумерный массив
        }
    }
    Console.WriteLine();
}