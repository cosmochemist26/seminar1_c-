//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

int a = ReadData ("Введите первое число: ");
int b = ReadData ("Введите второе число: ");
int c = ReadData ("Введите третье число: ");

if (TriangleTest(a,b,c)) PrintData("Может существовать такой треугольник");
else PrintData ("Такой треугольник не существует");

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c)&&(a + c > b)&&(b + c > a));
}