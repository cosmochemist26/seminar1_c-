// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

// получаем новое случайное число
int number = numberSintezator.Next(100,1000);

// Выводим данные в консоль
Console.WriteLine(number);

// Выводим первое и последнее число из трехзначного поотдельности
//int firstNumber = number/100;
//int secondNumber = number%10;

int result = (number/100)*10 + number%10;

//Выводим данные в консоль 
Console.WriteLine(result);