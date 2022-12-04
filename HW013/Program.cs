//Считываем данные с консоли в массив символов
char[] number = Console.ReadLine().ToCharArray();

if (number.Length >= 3) 
{
    //Выводим третью цифру в числе
    Console.WriteLine(number[2]);
}
else
{
    //Выводим ответ
    Console.WriteLine("Третьей цифры нет");
}

