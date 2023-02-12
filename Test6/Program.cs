//Напишите программу, ктр на вход принимает число и выдаёт, является ли число чётным(делится ли оно на 2 без остатка)
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int remDiv = num % 2;

if(remDiv == 0)
{
    Console.WriteLine("Четное");
    Console.WriteLine("Делится на 2 без остатка: Да");
}
else
{
    Console.WriteLine("Нечетное");
    Console.WriteLine("Делится на 2 без остатка: Нет");
}

