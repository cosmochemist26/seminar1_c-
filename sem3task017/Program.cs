﻿//Ввод координат

//Console.WriteLine("Введите координату X");
//int coordX = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine("Введите координату Y");
//int coordY = int.Parse(Console.ReadLine()??"0");

//Рефакторинг кода
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод определяет четверть
void PrintQuterTest()
{
  if(coordX>0&&coordY>0) Console.WriteLine("Точка в четверти I");

if(coordX>0&&coordY<0) Console.WriteLine("Точка в четверти II");

if(coordX<0&&coordY<0) Console.WriteLine("Точка в четверти III");

if(coordX<0&&coordY>0) Console.WriteLine("Точка в четверти IV");
 
}


int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");

PrintQuterTest()

