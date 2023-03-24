﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],3}  ");
        }
        Console.WriteLine();
    }
}
void Sortirovka(int [,] array)
{
//int temp= array[0,0];
    for(int i = 0; i< array.GetLength(0); i++)
    {
	for(int j = 0; j< array.GetLength(0); j++)
	
		for(int k=j+1; k<array.GetLength(1); k++)
		
		if(array[i,j]<array[i, k])
  	  (array[i,j],array[i,k]) =(array[i,k], array[i,j]);
    }
}


int [,] array = new int [8,8];


FillArray(array);
PrintArray(array);
Sortirovka(array);
Console.WriteLine();
PrintArray(array);