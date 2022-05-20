﻿// Спирально заполнить двумерный массив 
System.Console.WriteLine($"Программа, которая заполнит двумерный массив спирально:");
int N = 4, M = 4;
int[,] Array2D = new int[N, M];
int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M; 
for (int i = 0; i < Array2D.Length; i++)
{
    Array2D[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
            col += dx;
            row += dy;
}

        for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Array2D[i, j] + " ");
                }
                    Console.WriteLine();
            }
Console.ReadKey();  
