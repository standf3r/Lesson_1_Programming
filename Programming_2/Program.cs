// Задача 1: По двум заданным числам проверять является ли первое квадратом второго
// Задача 2: По заданному номеру дня недели вывести его название

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == (numberB * numberB))
{
    Console.Write("Первое число является квадратом второго числа");
}
else 
{
    Console.Write("Первое число не является квадратом второго числа");
}
