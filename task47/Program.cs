// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/*
Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
       
        matrix[i,j] = Convert.ToDouble(new Random().Next(-100 , 100)) / 10;
        Console.Write("["+matrix[i,j] + " " + "]" );
        
    }
    Console.WriteLine();
}
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
System.Console.WriteLine();

System.Console.Write("Введите индекс строки: ");
int FindNum1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца: ");
int FindNum2 = Convert.ToInt32(Console.ReadLine());
if( FindNum1 > matrix.GetLength(0) && FindNum2 > matrix.GetLength(1))
{
    System.Console.WriteLine("Числа по заданным индексам не обнаружено");
}
else
{
System.Console.WriteLine($" число под индексами {FindNum1} и {FindNum2} равно {matrix[FindNum1, FindNum2]}");
}