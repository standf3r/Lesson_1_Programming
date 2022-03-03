// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
  Console.WriteLine("Первое число является наибольшим");  
  Console.WriteLine(numberA);
  Console.WriteLine("Второе число является наименьшим");
  Console.WriteLine(numberB);
}
if (numberA < numberB)
{
  Console.WriteLine("Первое число является наименьшим");  
  Console.WriteLine(numberA);
  Console.WriteLine("Второе число является наибольшим");
  Console.WriteLine(numberB);
}
if (numberA == numberB)
{
  Console.WriteLine("числа равны");    
}