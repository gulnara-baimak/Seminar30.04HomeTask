// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 

Console.WriteLine($"Программа, которая найдет сумму элементов, стоящих на нечетных позициях");

int[] array = new int[10]; // задаю массив, состоящий из элементов
int sum = 0;
int count = 0;

for (int i = 0; i < array.Length; i++) //  тело цикла, если индекс меньше длины массива
{
    array[i] = new Random().Next(0, 100); // заполняю случайными числами
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++) //  тело цикла, если j меньше длины массива
{
    if (j % 2 != 0)  // перебираем нечетные позиции
    {
        sum = sum + array[j]; // суммируем элементы, стоящие на нечетных позициях
        count += array[j];
    } 
}
Console.Write($"Сумма элементов, стоящих на нечетных позициях: {sum}"); // выводим на экран
Console.WriteLine();
