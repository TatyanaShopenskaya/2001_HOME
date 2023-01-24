// Задача 19 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 9999) Console.WriteLine("Введено некорректное число. Введите пятизначное число");
if (number > -99999 && number < -9999) number = number * (-1);

int num1 = number /10000;
int num2 = number /1000%10;
int num4 = number % 100 / 10;
int num5 = number % 10;

if (num1 == num5) 
{
    if (num2 == num4)
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
