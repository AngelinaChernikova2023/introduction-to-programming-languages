﻿// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]    ");
}

int CountEvenDigitNumbers (int[] arr)
{   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr[i] % 2 == 0)
        count ++;       
    }
    return count;
}

Console.WriteLine();

int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);

Console.WriteLine();

int сountEvenDigitNumbers = CountEvenDigitNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве : {сountEvenDigitNumbers}");