﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа примет два числа и вычислит какое больше или установит равенство.");
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num2} больше {num1}");
}
else
{
    Console.WriteLine($"{num1} равняется {num2}");
}