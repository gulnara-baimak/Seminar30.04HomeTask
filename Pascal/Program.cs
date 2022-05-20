// ДЗ ЗАДАЧА 3. Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника 
// *Показать только нечетные числа в треугольнике
// C(n, k) = n! / (k! (n-k)!) формула вычесления - бином Ньютона

Console.WriteLine($"Программа, которая покажет треугольник Паскаля");
int row = 7; // локальная переменная, ряд
int[,] p = new int[row, row]; // ввожу переменные
const int k = 1;
void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        p[i, 0] = 1;
        p[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            p[i, j] = p[i - 1, j - 1] + p[i - 1, j];
        }
    }
}
void PrintPascal() 
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            if (p[i, j] != 0)
                Console.Write($"{p[i, j], k}");
        }
        Console.WriteLine();
    }
}

void FillPascal() //  метод по выведению треугольника 
{
    int col = k * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1); //  определим где начинается следующая операция записи в окне консоли
            if (p[i, j] % 2 != 0) Console.Write(p[i, j] );
            col += k * 2;
        }
        col = k * row - k * (i + 1);
        Console.WriteLine();
    }
    
}

FillTriangle();
PrintPascal();
Console.ReadLine();
FillPascal();