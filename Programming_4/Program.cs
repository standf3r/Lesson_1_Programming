﻿// Показать числа от -N до N

int NumberN = 0; //-N
int NumberN1 = 0; //N
Console.WriteLine( "Get number -N" );
NumberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Get number N" );
NumberN1 = Convert.ToInt32(Console.ReadLine());
if (NumberN > NumberN1){
  Console.WriteLine("Р’РІРµРґРµРЅС‹ РЅРµРІРµСЂРЅС‹Рµ РґР°РЅРЅС‹Рµ");

}
else while (NumberN <= NumberN1){
  Console.WriteLine("" + NumberN);
  NumberN += 1;
}