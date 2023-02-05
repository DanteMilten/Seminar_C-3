﻿// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

// Console.Clear();
// int number = ReadInt("Введите число: ");

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i}, ");
// }

// // Метод
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = N * (-1) N = -1
}
int[] result = new int[m];
int j = 0;
for (; i <= N; i++)
{
    result[j] = i * i;
    j++;
}
for ( j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}