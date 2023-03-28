﻿// Все задачи решаются с помощью рекурсии


// Задача 64. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void PrintNumberToOne(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        PrintNumberToOne(n, count + 1);
        Console.Write(count + " ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumberToOne(number, count);
*/


// Задача 66. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8  -> 30
/*
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int summa(int m, int n)
{
    if (m == n)
        return n;
    else
        return m + summa(m + 1, n);
}

Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна {summa(m, n)}");
*/



// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else // (m > 0 && n > 0)
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {(Akkerman(m, n))}");
*/