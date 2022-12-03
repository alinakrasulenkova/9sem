﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(n,1));
string PrintNum(int end, int start)
{
if (start==end)
{
return start.ToString();
}
return(end+ " "+PrintNum(end-1, start));

}