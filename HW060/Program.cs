// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

int[,,] Fill3DArray(int x, int y, int z, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    var tmp = new int[x * y * z];

    var result = new int[x, y, z];
    
    int num;

    for (int i = 0; i < tmp.Length; i++)
    {
        tmp[i] = rand.Next(topBorder, downBorder);
        num = tmp[i];

        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tmp[i] == tmp[j])
                {
                    tmp[i] = rand.Next(topBorder, downBorder);
                    j = 0;
                    num = tmp[i];
                }
            
            num = tmp[i];
            }
        }
    }

    int count = 0; 

    for (int a = 0; a < result.GetLength(0); a++)
    {
        for (int b = 0; b < result.GetLength(1); b++)
        {
            for (int c = 0; c < result.GetLength(2); c++)
            {
                result[a, b, c] = tmp[count];
                count++;
            }
        }
    }

    return result;
}

void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");

            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write( $"Z({k})={array3D[i,j,k]}; ");
            }

            Console.WriteLine();
        }

    Console.WriteLine();
    }
}

Console.WriteLine("Необходимо задать размерность массива X x Y x Z.");

int x = ReadData("Введите X: ");
int y = ReadData("Введите Y: ");
int z = ReadData("Введите Z: ");

int[,,] arr = Fill3DArray(x, y, z, 10, 100);

Print3DArray(arr);