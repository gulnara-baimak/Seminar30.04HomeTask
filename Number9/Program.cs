// Показать числа от -N до N

Console.WriteLine($"Программа, которая показывает числа от -N до N");
Console.WriteLine($"Введите число: ");  // определяем диапазон чисел для выведения в консоли
int maxValue = Convert.ToInt32(Console.ReadLine()); // максимальное значение
int minValue = - maxValue; // минимальное значение присваиваем отрицательное максимальное значение
while (minValue <= maxValue) // если минимальное значение меньше или равно максимального значения, то
{
    Console.Write(minValue + ","); // выводим в консоль
    minValue = minValue + 1; // минимальному значению присваиваем минимальное значение плюс 1
}
Console.WriteLine();