﻿// Выяснить является ли число чётным


// Сначала задача показалась трудной, сам решить не смог, полез в интернет по этому решению и нашел интересный способ как ее решить и разобрался с ним подробно. 
// Заключается в следующем: в этой задаче можно использовать логическое умножение. То есть конъюнкцию. 
// Любое число можно представить в двоичной системе счисления. Любое число представляется как сумма степеней двойки, умноженных на соответствующие коэффициенты.
// Нам в данной задаче интересен ТОЛЬКО последний байт числа. Если он равен нолю - число четное, если единице - нечетное. Команда (a&1) как раз это и определяет.


Console.Write("Введите значение для проверки на четность: ");
int a = Convert.ToInt32(Console.ReadLine());        
          // Проверка на четность

          if((a&1)==1)
             Console.WriteLine("Нечетное значение");
          else
             Console.WriteLine("Четное значение");
