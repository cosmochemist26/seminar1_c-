// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

//Универсальный метод заполнения двумерного массива

int[,] FillMatrix (int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] matrix = new int[countRow, countColumn];
    
    for (int i = 0; i < countRow; i++)
    {
        for (int elem = 0; elem < countColumn; elem++)
        {
            matrix[i,elem] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return matrix;
}

//Универсальный метод печати двумерного массива

void PrintMatrix(int[,] matrix)
{

    Console.WriteLine("Двухмерный массив: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int elem = 0; elem < matrix.GetLength(1); elem++)
        {
            Console.Write(matrix[i, elem] + " ");
        }

        Console.WriteLine();
    }

}

// bubble sort method

int[,] MatrixInvertBubbleSort(int[,] matrix)
{
    int tmp;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int elem = 0; elem < matrix.GetLength(1) - i - 1; elem++)
            {
                if (matrix[row, elem + 1] > matrix[row, elem])
                {
                    tmp = matrix[row, elem + 1];
                    matrix[row, elem + 1] = matrix[row, elem];
                    matrix[row, elem] = tmp;
                }
            }
        }
    }

    return matrix;
}

int row = ReadData("Введите количество строк для генерирования двухмерного массива: ");
int column = ReadData("Введите количество столбцов для генерирования двухмерного массива: ");

int[,] matrix = FillMatrix(row, column, 10, 99);

PrintMatrix(matrix);
PrintMatrix(MatrixInvertBubbleSort(matrix));
