Console.Write("Введите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.Write($"{num} день недели - Понедельник");
}
else if (num == 2)
{
    Console.Write($"{num} день недели - Вторник");
}
else if (num == 3)
{
    Console.Write($"{num} день недели - Среда");
}
else if (num == 4)
{
    Console.Write($"{num} день недели - Четверг");
}
else if (num == 5)
{
    Console.Write($"{num} день недели - Пятница");
}
else if (num == 6)
{
    Console.Write($"{num} день недели - Суббота");
}
else if (num == 7)
{
    Console.Write($"{num} день недели - Воскресенье");
}
else
{
    Console.Write("В неделе только 7 дней!"); //Вывод ошибки, если введено число не в диапазоне от 1 до 7
}
