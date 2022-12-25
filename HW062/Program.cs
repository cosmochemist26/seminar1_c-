// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

int[,] FillSpiralMatrix(int n, int m)
{
    var result = new int[n, m];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int changes = 0;
    int visits = m;

    for (int i = 0; i < result.Length; i++) 
    {
        result[row, col] = i + 1;

        if (--visits == 0) 
        {
            visits = m * (changes %2) + n * ((changes + 1) %2) - (changes/2 - 1) - 2;

            int temp = dx;
            dx = -dy;
            dy = temp;
            changes++;
        }

        col += dx;
        row += dy;
    }

    return result;
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

int row = ReadData("Введите количество строк для заполнения двухмерного массива: ");
int column = ReadData("Введите количество столбцов для заполнения двухмерного массива: ");

int[,] matrix = FillSpiralMatrix(row, column);

PrintMatrix(matrix);
