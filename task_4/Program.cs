﻿// Задача 4. Напишите программу, которая принимает на вход 3 числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 --> 7
// 44, 5, 78 --> 78
// 22, 3, 9 --> 22

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("И в завершение, введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Максимальным числом является число " + max);
