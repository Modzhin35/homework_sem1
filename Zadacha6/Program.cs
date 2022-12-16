Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string answer;
if (num % 2 == 0)
{
    answer = "четное";
}
else
{
    answer = "нечетное";
}
Console.Write($"Ваше число {num} {answer}");
