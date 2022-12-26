System.Console.Write("Введите первое число");     
  int number1 = Convert.ToInt32(System.Console.ReadLine());

  System.Console.Write("Введите второе число");
  int number2 = Convert.ToInt32(System.Console.ReadLine());

  System.Console.Write("Введите третье число");     
  int number3 = Convert.ToInt32(System.Console.ReadLine());

 int number;

 int max = 0;

for ( int i = 0; i < 3; i++)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number > max)
  {
        max = number;
  }
}

System.Console.WriteLine(max);