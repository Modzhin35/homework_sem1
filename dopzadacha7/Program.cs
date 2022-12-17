Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num % 10;
Console.Write($"Последняя цифра вашего числа {num}");