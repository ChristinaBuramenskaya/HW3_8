﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(5);
        }
    }
}

void PrintSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void Result(int[,] array)
{
    int min = 0;

    int x = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (sum < min)
        {
            min = sum;
            x = i;
        }


    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {x}");
}


int[,] collection = new int[3, 5];
FillArray(collection);
PrintSortArray(collection);
Console.WriteLine();
Result(collection);