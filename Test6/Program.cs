Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int remDiv = num % 2;

if(remDiv == 0)
{
    Console.WriteLine("Делится на 2 без остатка: Да");
}
else
{
    Console.WriteLine("Делится на 2 без остатка: Нет");
}

