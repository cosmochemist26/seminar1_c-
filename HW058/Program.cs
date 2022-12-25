// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

bool IsMatrixMultiplyPossible(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] = result[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

int row = ReadData("Введите количество строк для генерирования двухмерного массива: ");
int column = ReadData("Введите количество столбцов для генерирования двухмерного массива: ");

int[,] matrix1 = FillMatrix(row, column, 10, 99);

PrintMatrix(matrix1);

row = ReadData("Введите количество строк для генерирования двухмерного массива: ");
column = ReadData("Введите количество столбцов для генерирования двухмерного массива: ");

int[,] matrix2 = FillMatrix(row, column, 10, 99);

PrintMatrix(matrix2);

if (IsMatrixMultiplyPossible(matrix1, matrix2))
{
    Console.WriteLine("Результат перемножения матриц:");
    PrintMatrix(MatrixMultiply(matrix1, matrix2));
}
else
{
    Console.WriteLine("Перемножить матрицы нельзя!");
}


