//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int a, a2;
Console.WriteLine("Введите трехзначное число: ");
a = int.Parse(Console.ReadLine()!);
if(a < 100 || a > 999)
{
    System.Console.WriteLine("Это не трехзначное число");
}
else
{
    a2 = (a / 10) % 10;
    System.Console.WriteLine($"Вторая цифра это {a2}");
}