﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {m} строки и {n} столбца = {numbers[m-1,n-1]}");
}
void FillArrayRandomNumbers(int[,] array)//Заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}
void PrintArray(int[,] array)//Вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("|");
        Console.WriteLine(""); 
    }
}