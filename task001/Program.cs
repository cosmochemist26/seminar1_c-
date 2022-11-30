//Считываем данные с консоли
string? num1Line = Console.ReadLine(); 
string? num2Line = Console.ReadLine(); 

//Проверяем, чтобы данные были не пустыми
if (num1Line!=null&&num2Line!=null);
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    //Находим произведение чисел
    int outResult = num1*num2;
    //или int outResult = (int)Math.Pow(inputnum,2);


    //Выводим данные в консоль
    Console.WriteLine(outResult);
    //или Console.Writeline(MathPow(int.Parse(inputLine),2));
}