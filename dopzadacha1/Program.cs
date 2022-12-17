Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, которое является квадратом первого, или не является. На ваш выбор: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 * num1;
if (num2 == res)
{
    Console.Write($"Число {num2} является квадратом числа {num1}");
}
else
{
    Console.Write($"Число {num2} не является квадратом числа {num1}");
}