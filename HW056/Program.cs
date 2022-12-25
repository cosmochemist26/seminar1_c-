// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int FindRowInMatrixMinElemSum(int[,] matrix)
{

    int found_row = 0;

    int min_sum = 0;

    for (int elem = 0; elem < matrix.GetLength(1); elem++)
    {
        min_sum += matrix[0, elem];
    }


    for (int row = 1; row < matrix.GetLength(0); row++)
    {
        int sum = 0;

        for (int elem = 0; elem < matrix.GetLength(1); elem++)
        {
            sum += matrix[row, elem];
        }

        if (min_sum > sum)
        {
            min_sum = sum;
            found_row = row;
        }

    }

    return found_row + 1;
}

int row = ReadData("Введите количество строк для генерирования двухмерного массива: ");
int column = ReadData("Введите количество столбцов для генерирования двухмерного массива: ");

int[,] matrix = FillMatrix(row, column, 10, 99);

PrintMatrix(matrix);

Console.WriteLine("Строка с наименьшей суммой: " + FindRowInMatrixMinElemSum(matrix));



