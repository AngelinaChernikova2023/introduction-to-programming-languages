﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// m = 3, n = 4.

// 1  4  8  19
// 5  -2  33  -2
// 77  3  8  1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
    }



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("[ ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 4} ");
    }
    Console.WriteLine("]    ");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
// // [1 2 3 4 5] -> [5 4 3 2 1]
// void ReversArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
// }

// int[] array = CreateArrayRndInt(5, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// ReversArray(array);
// PrintArray(array);
// Console.WriteLine();

// //Встроенный метод разворота массива!!!
// Array.Reverse(array);
// PrintArray(array);
