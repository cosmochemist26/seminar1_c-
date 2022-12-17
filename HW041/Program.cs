//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] ReadArray(string msg)
{
    Console.WriteLine(msg);

    string Input = Console.ReadLine() ?? "0";
    string[] SubStrings = Input.Split(", ");

    List<int> Array = new List<int>();

    foreach (var SubString in SubStrings) 
    {
        Array.Add(int.Parse(SubString));
    }

    return Array.ToArray();
}

int PosNumCount(int[] arr)
{
    int count = 0;
    foreach (var num in arr)
    {
        if (num > 0) 
        {
            count++;
        }
    }
    return count;
}
int[] Array = ReadArray("Введите числа через запятую: ");
Console.WriteLine("Количество чисел больше нуля: " + PosNumCount(Array).ToString());

