//Считываем данные с консоли
int day = int.Parse(Console.ReadLine());

if (day >= 1 && 
    day <= 7)
{
    if (day > 5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
