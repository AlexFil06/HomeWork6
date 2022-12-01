﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// k1x + b1 = k2x + b2
// k1x = k2x + (b2-b1)
// (k1-k2)x = (b2-b1) 

// x= (b2-b1)/(k1-k2)          x=(4-2)/(5-9)= 2/-4= -0.5
// y = k1(b2-b1)/(k1-k2)+b1    y= 5(4-2)/(5-9)+2=  5*2/-4+2  = 10/-4+2 = -0.5              
// y = k2(b2-b1)/(k1-k2)+b2    y = 9(4-2)/(5-9)+4 = 9*2/-4+4 = -4.5 + 4 = -0.5


Console.Write("Введите значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
