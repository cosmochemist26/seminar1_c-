//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// y = k1 * x + b1
// y = k2 * x + b2

// 0 = k1 * x + b1 - k2 * x - b2
// y = k2 * x + b2

// x = (b2 - b1) /  (k1 - k2)
// y = k2 * x + b2

int ReadNumber(string msg)
{
    Console.WriteLine(msg);

    string? Line = Console.ReadLine() ?? "0";

    return int.Parse(Line);
}

double[] IntersectionPoint(int b1, int b2, int k1, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;

    double[] arr = new double[2];

    arr[0] = x;
    arr[1] = y;
    
    return arr;
    
}

int b1 = ReadNumber("Введите b1: ");
int b2 = ReadNumber("Введите b2: ");
int k1 = ReadNumber("Введите k1: ");
int k2 = ReadNumber("Введите k2: ");

double[] point = IntersectionPoint(b1, b2, k1, k2);

string x = point[0].ToString();
string y = point[1].ToString();

Console.WriteLine("Точка пересечения прямых: " + x + ", " + y);