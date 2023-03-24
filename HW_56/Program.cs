// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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
void Podschet(int [,] array, int [] summa)
{
int sum = array[0,0];
	for(int i = 0; i< array.GetLength(0); i++)
	{	
	for(int j = 0; j< array.GetLength(0); j++)
	summa[i]+= array[i,j];
    }
}

void PrintSumm(int [] summa)
{	
	int temp= summa[0];
	int index= 0;
	for(int i= 0; i<summa.Length; i++)
	{
		if(summa[i]<temp)
		{
			temp = summa[i];
			index= i+1;
		}	
	}
	
Console.WriteLine($"Наименьшая сумма элементов равна: {temp}, они находятся в строке:"  + index);
}



int [,] array = new int [5,5];
int[] summa = new int[array.GetLength(0)];


FillArray(array);
PrintArray(array);
Podschet(array, summa);
PrintSumm(summa);