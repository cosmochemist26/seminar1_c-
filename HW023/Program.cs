int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

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




