// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента

Console.WriteLine("Программа сформирует трехмерный массив не повторяющимися двухзначными числами и покажет его построчно на экране");

void PrintArray(int[,,] array3D)//  метод: выводим матрицу в консоли
{
    for (int i = 0; i < 4; i++) // строки
    {
        for (int j = 0; j < 4; j++) // столбцы
        {
            for (int l = 0; l < 4; l++)
            {
                Console.Write($"{array3D[i, j, l]} "); // косноль: выводим на экран
            }
        }
                Console.WriteLine();
    }
   
} 

void FillArray(int[,,] matr) // метод: заполняем матрицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) // cтроки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            for (int l = 0; l < matr.GetLength(2); l++)
            {
                matr[i, j, l] = new Random().Next(10,99); // генератор случайных чисел
            }
        }
        
    }
}

int k = 4;
int n = 4;
int q = 4;
int[,,] array3D = new int[k, n, q];
PrintArray(array3D);
Console.WriteLine();
FillArray(array3D);
PrintArray(array3D);
Console.WriteLine(); 