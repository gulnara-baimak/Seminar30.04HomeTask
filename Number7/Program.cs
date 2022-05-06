// Заданы три числа:a, b, c. Определить, могут ли они быть сторонами треугольника. 
// И если да, то определить его тип: равносторонний, равнобедренный, разносторонний.

Console.WriteLine($"Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if ( ( a >= b + c ) || ( b >= a + c ) || ( c >= a + b ) )
{
    Console.WriteLine("не треугольник");
}
    else if ( a == b && b == c )
    {
        Console.WriteLine("равносторонний треугольник");
    }
        else if ( ( a == b ) || ( a == c ) || ( b == c ) )
        {
            Console.WriteLine("равнобедренный треугольник");
        }
            else Console.WriteLine("просто треугольник");
            
