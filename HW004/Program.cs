//Считываем данные с консоли
string? num1Line = Console.ReadLine(); 
string? num2Line = Console.ReadLine(); 
string? num3Line = Console.ReadLine(); 

//Проверяем, чтобы данные были не пустыми
if (num1Line != null && num2Line != null && num3Line != null)
{

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    // Вводим переменную
    int max = num1;

    //Сравниваем числа
    if (num2 > max)
    {
        max = num2;
    }
    if (num3 > max)
    {
        max = num3;
    }
    
    Console.WriteLine(max);
}
