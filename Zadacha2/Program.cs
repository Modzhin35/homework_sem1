﻿Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
}
