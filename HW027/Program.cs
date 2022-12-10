//Считываем данные с консоли в массив символов
int[] ReadIntArray(string msg)
{
    Console.WriteLine(msg);

    string? Line = Console.ReadLine() ?? "0";
    char[] Array = Line.ToCharArray();

    int[] IntArray = new int[Array.Length];

    if (Array[0] == '-')
    {
        for (int i = 1; i < Array.Length; i++)
        {
            IntArray[i-1] = int.Parse(Array[i].ToString());
        }
    
    }
    else
    {

        for (int i = 0; i < Array.Length; i++)
        {
            IntArray[i] = int.Parse(Array[i].ToString());
        }
    }
    
    return IntArray;
}

int SumOfDigits(int[] Array)
{
    int sum = 0;
    
    for (int i = 0; i < Array.Length; i++) 
    {
       sum = sum + Array[i];
    }

    return sum;
}

int[] number = ReadIntArray("Введите число");

Console.WriteLine(SumOfDigits(number));


