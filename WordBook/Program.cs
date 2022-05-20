//ДЗ ЗАДАЧА 1. Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillArray(int[,] array) // метод: заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++) //  возвращает количество cтрок
    {
        for (int j = 0; j < array.GetLength(1); j++) // возвращает количество столбцов
        {
            array[i, j] = new Random().Next(1,10); // генератор случайных чисел
            Console.Write($"{array[i, j]} "); // косноль: выводим на экран
        }
            Console.WriteLine(); 
    }
}
int x = 3;
int y = 4;
int[,] array = new int[x, y]; // двумерный массив

FillArray(array);
Console.WriteLine(); 

int[,] wordbook = new int[x * y, 2];//  ввожу новый тип данных
int c = 0;
bool exist = false; // будем возвращать ложь
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
           exist = false;  
           for (int z = 0; z < c; z++)
           {
               if (wordbook[z, 0] == array[i, j])
               {
                   wordbook[z, 1]++;
                   exist = true;
                   break;
               }
           }
         if (exist == false)
            {
            wordbook[c, 0] = array[i, j];
            wordbook[c, 1]++;
            c++;
            }
    
        }
    }
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < wordbook.GetLength(1); j++)
    {
        Console.Write($"{wordbook[i, +j]} ");
    }
        Console.WriteLine();
}
}