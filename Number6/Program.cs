// Выяснить являются ли три числа сторонами треугольника

Console.WriteLine($"Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if ((a + b > c) && (a + c > b) && (b + c > a)) 
{ 
    Console.WriteLine("Числа являются сторонами треугольника");
}
else Console.WriteLine("Числа не являются сторонами треугольника");
Console.WriteLine();
        


