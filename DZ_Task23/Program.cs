﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите целое число А");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} | {count * count * count}");
        count++;
    }
}
// Другое решение!!!
// Console.WriteLine("Введите целое число А");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine($"{i * i * i} ");
// }

// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }