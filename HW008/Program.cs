//Считываем данные с консоли
string? nLine = Console.ReadLine(); 

//Проверяем, чтобы данные были не пустыми
if (nLine != null)
{    
    //Парсим введенное число
    int n = int.Parse(nLine);

    for (int i = 1; i < n + 1; i++)
    {
        //Ищем остаток от деления

        int mod = i % 2; 

        if (mod == 0)
        {
            Console.WriteLine(i);
        }
        
    }

}