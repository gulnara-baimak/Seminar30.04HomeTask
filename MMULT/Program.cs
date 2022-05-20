// ДЗ ЗАДАЧА 2. Найти произведение двух матриц.

System.Console.WriteLine($"Программа, которая находит произведение двух матриц:");
void FillArray(int[,] A, int[,] B)
{
    for (int m = 0; m < A.GetLength(0); m++)
    {
        for (int n = 0; n < A.GetLength(1); n++)
        {
           A[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < B.GetLength(0); m++)
    {
        for (int n = 0; n < B.GetLength(1); n++)
        {
            B[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] A, int[,] B)
{
    for (int m = 0; m < A.GetLength(0); m++)
    {
        for (int n = 0; n < A.GetLength(1); n++)
        {
        Console.Write($"{A[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < B.GetLength(0); m++)
    {
        for (int n = 0; n < B.GetLength(1); n++)
        {
            Console.Write($"{B[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] A, int[,] B, int[,] C)
{
    for (int m = 0; m < A.GetLength(0); m++)
    {
        for (int n = 0; n < B.GetLength(1); n++)
        {
            C[m, n] = A[m, n] * B[m, n];
        }
    }
}

void PrintCompArray(int[,] C)
{
    for (int m = 0; m < C.GetLength(0); m++)
    {
        for (int n = 0; n < C.GetLength(1); n++)
        {
            Console.Write($"{C[m, n]} ");
        }
        Console.WriteLine();
    }
}
int[,] A = new int[2, 2];
int[,] B = new int[2, 2];
int[,] C = new int[2, 2];
FillArray(A, B);
PrintArray(A, B);
Console.WriteLine();
Composition(A, B, C);
PrintCompArray(C);
