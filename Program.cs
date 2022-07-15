﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 1 || dayNumber > 7)
{
    Console.Write("Введите значение от 1 до 7");
}
else if (dayNumber == 6 || dayNumber == 7) Console.WriteLine("Этот день является выходным.");