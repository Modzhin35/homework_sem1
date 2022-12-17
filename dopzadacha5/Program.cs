Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numRev = -num;
while (numRev <= num)
{
    Console.Write($"{numRev} ");
    numRev++;
}