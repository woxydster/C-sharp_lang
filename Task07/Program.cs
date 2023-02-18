﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа - {lastNumber}");
}
else
{
    Console.Write("Вы ввели НЕ трехзначное число!");
}