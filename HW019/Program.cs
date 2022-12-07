int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void is_palindrome(int number)
{
    int first = number / 10000;
    int second = number / 1000 % 10;
    int fourth = number / 10 % 10;
    int fifth = number % 10;

    if ( first == fifth && second == fourth)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }

}

int number = ReadData("Введите пятизначное число");

is_palindrome(number);



