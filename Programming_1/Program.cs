// Вывести квадрат числа
Console.Write("Введите число, которое вам необходимо возвести в квадрат: ");

// Конвертируем строку в целое число
// При использовании вещественных числе используеся команда double. Для конвертирования далее применяется команда Convert.ToDouble
int numberValue = Convert.ToInt32(Console.ReadLine());

int numberA = (numberValue * numberValue);
Console.Write("Данное число в квадрате равняется - ");
Console.Write(numberA);

