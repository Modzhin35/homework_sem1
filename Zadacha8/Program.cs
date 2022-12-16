Console.Write("Введите любое число больше единицы: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2)
{
    Console.Write("Число должно быть больше единицы!"); //В задаче условия вывести числа от 1 до N
}
int i = 2;
while (i <= num)
{
    Console.Write($"{i} ");
    i += 2;
}
