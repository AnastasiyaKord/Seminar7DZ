﻿// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[7, 7];

FillArray(numbers);
PrintArray(numbers);

FillArray(numbers);

if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента строки <{rows}> и столбца <{columns}> равно: <{numbers[rows - 1, columns - 1]}>");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}