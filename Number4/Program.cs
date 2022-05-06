// Написать программу замену элементов массива на противоположные

int[] array = new int[10]; // 
Console.WriteLine("Введите размерность массива: ");
for (int i = 0; i < array.Length; i++) // тело цикла, если i меньше длины массива
{
    array[i] = new Random().Next(0, 100); // задаю массив из 10 элементов
    Console.Write(array[i] + "," );
}
Console.WriteLine();
void Print(int[] array) // метод
{
for (int j = 0; j < array.Length; j ++)  // тело цикла на замену элементов массива на противоположные
{
    array[j] = - 1 * array[j]; // здесь идет замена элементов на противоположные
    Console.Write(array[j] + ",");
}
}
Console.WriteLine($"Полученный результат: ");
Print (array); // выводим результат
Console.WriteLine();
