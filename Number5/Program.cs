// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[11]; 

Console.WriteLine("Одномерный массив: ");
for (int i = 0; i < array.Length; i++) // тело цикла
{
    array[i] = new Random().Next(0, 10); // задаю массив из случайных элементов 
    Console.Write(array[i] + "," );
}
Console.WriteLine();

int j = array.Length - 1;
Console.WriteLine($"Полученный результат: ");
for (int i = 0; i < array.Length / 2; i++) // тело цикла
{
    Console.Write(array[i] * array[j] + ",");
    j--;
}
Console.WriteLine();