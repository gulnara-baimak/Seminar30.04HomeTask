// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int[] array = {8, 10, 51, 13, 81, 56, 5};
int maxValue = array[0];
int minValue = array[0];

for (int i = 0; i < array.Length; i++) // задаю массив вещественных чисел
{
    Console.Write( array[i] + " "); // вывожу их на экран

    if (array[i] > maxValue) // ищем максимальный элемент массива
    {
        maxValue = array[i];
    }

    if (array[i] < minValue) // ищем минимальный элемент массива
    {
        minValue = array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным элементом и минимальным элементом равна:  ");
Console.Write(maxValue - minValue); // вывожу разницу 
Console.WriteLine();
