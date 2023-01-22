﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero); //округление

double Distance (int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Sqrt(Math.Pow((xc2-xc1),2)+Math.Pow((yc2-yc1),2)+Math.Pow((zc2-zc1), 2));
}

Console.WriteLine($"Расстояние между точками в 3D пространстве {distanceRound}");




