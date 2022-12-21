﻿//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Универсальный метод заполнения двумерного массива

int [,] Fill2DArray (int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int [,] array2D = new int[countRow, countColumn];
    
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Универсальный метод печати двумерного массива

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }

}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int [,] arr2D = Fill2DArray(row,column,10,99);
Print2DArray(arr2D);

