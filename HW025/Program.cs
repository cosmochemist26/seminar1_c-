int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

int A = ReadNumber("Введите число A");
int B = ReadNumber("Введите число B");

Console.WriteLine("A^B = " + Math.Pow(A,B));


