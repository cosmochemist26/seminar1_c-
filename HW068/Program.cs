//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int ComputeAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return ComputeAkkerman(m - 1, 1);
    else
        return ComputeAkkerman(m - 1, ComputeAkkerman(m, n - 1));
}

Console.WriteLine("Введите два положительных числа: m и n");

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

Console.WriteLine($"A({m}, {n}) = {ComputeAkkerman(m, n)}");