﻿// Напишите программу, которая принимает 
// на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance(x1, y1, x2, y2, z1, z2);
double distRound = Math.Round(dist, 3);
Console.Write("Расстояние между A и B: " + distRound);

double GetDistance(int a1, int a2, int b1, int b2, int z1, int z2)
{
    double firstCatet = b1 - b2;
    double secondCatet = a1 - a2;
    double thirdCatet = z1 - z2;
    double distance = Math.Sqrt(firstCatet * firstCatet + secondCatet * secondCatet + thirdCatet * thirdCatet);
    return distance;
}