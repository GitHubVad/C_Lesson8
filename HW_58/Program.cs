// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] matrix1 = new int [2,2];
int [,] matrix2 = new int [2,2];
int [,] matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
		
void FillMatrix1(int[,] matrix1)
{
    for(int i = 0; i< matrix1.GetLength(0); i++)
    {
        for (int j = 0; j< matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = new Random().Next(1, 10);
        }
    }
}
void FillMatrix2(int[,] matrix2)
{
    for(int i = 0; i< matrix2.GetLength(0); i++)
    {
        for (int j = 0; j< matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix1(int[,] matrix1)
{
    for(int i = 0; i< matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i,j],3}  ");
        }
        Console.WriteLine();
    }
}
void PrintMatrix2(int[,] matrix2)
{
    for(int i = 0; i< matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i,j],3}  ");
        }
        Console.WriteLine();
    }
}

void Podschet(int [,] matrix1, int [,] matrix2)
{	

	for(int i = 0; i< matrix1.GetLength(0); i++)
	{	
		for(int j = 0; j< matrix2.GetLength(1); j++)

			for(int k = 0; k< matrix1.GetLength(1); k++)
					
				matrix3[i,j]+= matrix1[i,k]*matrix2[k,j];
				
	}			
			for(int o = 0; o< matrix3.GetLength(0); o++)
    {
        for (int p = 0; p < matrix3.GetLength(1); p++)
        {
            Console.Write($"{matrix3[o,p],3}  ");
        }
        Console.WriteLine();
    }
				
}    

FillMatrix1(matrix1);
FillMatrix2(matrix2);
PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);
Console.WriteLine();
Podschet(matrix1, matrix2);

//Podschet(matrix1, matrix2, matrix3);
