// Задайте массив заполненный случайными положительными трёхзначными числами (диапазон от 100 до 999 будет в рандом). 
// Напишите программу, которая покажет количество чётных и нечетных чисел в массиве.

Console.WriteLine($"Программа, которая покажет количество четных и нечетных чисел в массиве.");

int[] array = new int[7]; // задаю массив, состоящий из 7 элементов
int numberEven = 0; // переменная четное число
int numberOdd = 0; // переменная нечетное число

for (int i = 0; i < array.Length; i++) //  тело цикла, если индекс меньше длины массива
{
    array[i] = new Random().Next(100, 999); // заполняю случайными трехзначными числами
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++) //  тело цикла, если j меньше длины массива
{
    if (array[j] % 2 == 0) numberEven = numberEven + 1; // здесь проверяем на четность число
    else numberOdd = numberOdd + 1;
}
Console.Write($"Количество четных чисел: " + numberEven); // выводим на экран
Console.WriteLine();
Console.Write($"Количество нечетных чисел: " + numberOdd); // выводим на экран
Console.WriteLine();
