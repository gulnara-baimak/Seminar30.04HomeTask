// Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.WriteLine($"Программа, которая обменяет элементы первой строки и последней строки: ");
void FillArray(int[,] array) // заполняю массив случайными числами от 1 до 20 и вывожу в консоли
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write(array[i, j] + "  ");
        }
            Console.WriteLine();
    }
}
Console.WriteLine();

void ExchangeArray(int[,] array) // обмен первой и последней строки
{
int m = 0; // ввожу переменную для хранения новых значений
for (int i = 0; i < array.GetLength(1); i++)
    {
        m = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = m;
    }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "  ");
            }
            Console.WriteLine();
        }
    
}
Console.WriteLine();
int[,] matrix = new int[4,5];
FillArray(matrix);
Console.WriteLine("================");
ExchangeArray(matrix);
Console.WriteLine("Спасибо за внимание!");
