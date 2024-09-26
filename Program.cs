// See https://aka.ms/new-console-template for more information

using System;
//Задание 2_1
//Вывод и ввод данных в консоль для первого пользователя
Console.WriteLine("Требуется выполнить ввод данных о первом пользователе:");
Console.WriteLine("Имя");
string? name1 = Console.ReadLine();
Console.WriteLine("Фамилия");
string? surname1 = Console.ReadLine();
Console.WriteLine("Отчество");
string? patronymic1 = Console.ReadLine();



// Вывод и ввод данных в консоль для второго пользователя
Console.WriteLine("Требуется выполнить ввод данных о втором пользователе:");
Console.WriteLine("Имя");
string? name2 = Console.ReadLine();
Console.WriteLine("Фамилия");
string? surname2 = Console.ReadLine();
Console.WriteLine("Отчество");
string? patronymic2 = Console.ReadLine();


// Вывод и ввод данных в консоль для третьего пользователя
Console.WriteLine("Требуется выполнить ввод данных о третьем пользователе:");
Console.WriteLine("Имя");
string? name3 = Console.ReadLine();
Console.WriteLine("Фамилия");
string? surname3 = Console.ReadLine();
Console.WriteLine("Отчество");
string? patronymic3 = Console.ReadLine();


//Создание массива с последующим заполнением массива данными
string[] arr = new string[3];
arr[0] = name1;
arr[1] = surname1;
arr[2] = patronymic1;


string[] arr2 = new string[3];
arr2[0] = name2;
arr2[1] = surname2;
arr2[2] = patronymic2;


string[] arr3 = new string[3];
arr3[0] = name3;
arr3[1] = surname3;
arr3[2] = patronymic3;

//Вывод данных об указанном пользователе
Console.WriteLine("Введите имя пользователя для получения данных о пользователе");
string user = Console.ReadLine();

if (user == name1)
{
    Console.WriteLine($"Данные о пользователе:");
    Console.WriteLine($"Имя: {arr[0]} Фамилия: {arr[1]} Отчество: {arr[2]}");
}

else if (user == name2)
{
    Console.WriteLine($"Данные о пользователе:");
    Console.WriteLine($"Имя: {arr2[0]} Фамилия: {arr2[1]} Отчество: {arr2[2]}");
}
else if (user == name3)
{
    Console.WriteLine($"Данные о пользователе:");
    Console.WriteLine($"Имя: {arr3[0]} Фамилия: {arr3[1]} Отчество: {arr3[2]}");
}
else if (user != name1 || user != name2 || user != name3)
{
    Console.WriteLine($"Отсутствуют данные о пользователе с указанным именем.");
}