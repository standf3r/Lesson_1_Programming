// Выяснить является ли число чётным

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA * 2)
{
    Console.Write("Данное число является четным");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("Данное число не является четным");
    Console.WriteLine(numberA);
}