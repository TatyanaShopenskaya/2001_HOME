// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Введено некорректное число. Введите натуральное значение.");

int num = 1;
while (num <= number)
{
    Console.WriteLine($"{number} => {num * num * num}");
    num++;
}