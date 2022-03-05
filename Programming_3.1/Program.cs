// Решение задачи с определением дня недели по вводу числа с помощью команд switch and case

Console.WriteLine("Введите номер дня недели: ");
int NumberOfWeek = Convert.ToInt32(Console.ReadLine());
switch (NumberOfWeek){
  case 1:
  {
    Console.WriteLine( "Monday");
    break;
  }
  case 2:
  {
    Console.WriteLine( "Tuesday");
    break;
  }
  case 3:
  {
    Console.WriteLine( "Wednesday");
    break;
  }
  case 4:
  {
    Console.WriteLine( "Thursday");
    break;
  }
  case 5:
  {
    Console.WriteLine( "Friday");
    break;
  }
  case 6:
  {
    Console.WriteLine( "Saturday");
    break;
  }
  case 7:
  {
    Console.WriteLine( "Sunday");
    break;

  }
}