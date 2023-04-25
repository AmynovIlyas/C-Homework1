// Напишите прорамму, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7; max --> 7
// a = 2; b = 10; max --> 10
// a = -9; b = -3; max --> -3

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("max = " + a);
}
else if (a == b)
{
    Console.WriteLine("Введённые Вами числа равны");
}
else 
{
    Console.WriteLine("max = " + b);
}
