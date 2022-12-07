//Метод(функция), которая считывает ввод с консоли и преобразует(парсит) его в число типа инт

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод распечатки значений кубов от 1 до N в табличном виде
void PrintCubes(int N)
{
    Console.WriteLine("_________________________________");
    Console.WriteLine("|\ti\t|\tCube\t|");
    Console.WriteLine("|_______________|_______________|");
    
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine("|\t" + i + "\t|\t" + Math.Pow(i, 3) + "\t|");
    }
    
    Console.WriteLine("|_______________|_______________|");

}

PrintCubes(ReadNumber("Введите N"));




