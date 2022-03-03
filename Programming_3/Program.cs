// Задача 2: По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
string dayname= "";
if (day ==1)dayname = "понедельник";
if (day ==2)dayname = "вторник";
if (day ==3)dayname = "среда";
if (day ==4)dayname = "четверг";
if (day ==5)dayname = "пятница";
if (day ==6)dayname = "суббота";
if (day ==7)dayname = "воскресенье";
Console.WriteLine(dayname);
