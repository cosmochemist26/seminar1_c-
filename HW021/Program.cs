//Метод считывания данных с консоли в формате x y z и преобразует в массив вещественных чисел

double[] ReadPointCoord(string msg)
{
    Console.WriteLine(msg);

    string Input = Console.ReadLine() ?? "0 0 0";
    string[] StringCoords = Input.Split(" ");

    List<double> Coords = new List<double>();

    foreach (var StringCoord in StringCoords) 
    {
        Coords.Add(double.Parse(StringCoord));
    }

    return Coords.ToArray();
}

//Метод определения расстояния между двумя точками в трехмерном пространстве

double CalcDistance(double[] a, double[] b)
{
    double Distance = 0.0;

    for (int i = 0; i < a.Length; i++)
    {
        Distance += Math.Pow(b[i] - a[i], 2);
    }
    
    return Math.Round(Math.Sqrt(Distance), 2);
    
}

//вызов методов

double[] a = ReadPointCoord("Введите координаты точки А через пробел:");
double[] b = ReadPointCoord("Введите координаты точки B через пробел:");

Console.WriteLine(CalcDistance(a, b));

