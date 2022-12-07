//Ввод координат

Console.WriteLine("Введите координату X");
int coordX = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите координату Y");
int coordY = int.Parse(Console.ReadLine()??"0");

if(coordX>0&&coordY>0) Console.WriteLine("Точка в четверти I");

if(coordX>0&&coordY<0) Console.WriteLine("Точка в четверти II");

if(coordX<0&&coordY<0) Console.WriteLine("Точка в четверти III");

if(coordX<0&&coordY>0) Console.WriteLine("Точка в четверти IV");

