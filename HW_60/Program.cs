// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] matrix1 = new int [2,2,2];
FillMatrix1(matrix1);
PrintMatrix1(matrix1);
		
void FillMatrix1(int[,,] matrix1)
{
    for(int i = 0; i< matrix1.GetLength(0); i++)
    {
        for (int j = 0; j< matrix1.GetLength(1); j++)
        {
			for (int k = 0; k< matrix1.GetLength(2); k++)
			{
            	matrix1[i,j,k] = new Random().Next(1, 10);
			}	
        }
    }
}


void PrintMatrix1(int[,,] matrix1)
{
	
    for(int i = 0; i< matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
		{
			for (int k = 0; k< matrix1.GetLength(2); k++)
        	{
            Console.Write($"{matrix1[i,j,k]}{(i,j,k)}   ",3);
        	}
		}
     Console.WriteLine();
    }
}