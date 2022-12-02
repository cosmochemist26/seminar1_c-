//Считываем данные с консоли
string? num1Line = Console.ReadLine(); 


//Проверяем, чтобы данные были не пустыми
if (num1Line != null)
{

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    
    //Ищем остаток от деления

    int mod = num1 % 2; 

    if (mod == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    
}
