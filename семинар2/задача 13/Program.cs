//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()!);
while (num>1000)
{
    num/=10;
}
int num1 = num % 10;
Console.WriteLine($"Третья цифра: {num1}");