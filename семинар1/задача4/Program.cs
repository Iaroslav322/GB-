//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Первое число {num1} больше чем второе {num2} и третье {num3}");
}
else if (num2 > num3)
{
    Console.WriteLine($"Второе число {num2} больше чем первое {num1} и третье {num3}");
}
else
{
    Console.WriteLine($"Третье число {num3} больше чем первое {num1} и второе {num2} ");
}