//Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int RecSumNat(int m, int n)
{
    if (m > n)
    {
        return m + RecSumNat(n, m - 1);
    }

    if (m < n)
    {
        return n + RecSumNat(m, n - 1);    
    }

    return n;
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");

Console.WriteLine($"Сумма элементов от {m} до {n} = {RecSumNat(m, n)}");