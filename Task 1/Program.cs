System.Console.Write("Введите первое число");     
  int number1 = Convert.ToInt32(System.Console.ReadLine());

  System.Console.Write("Введите второе число");
  int number2 = Convert.ToInt32(System.Console.ReadLine());

  if (number1 > number2)
{
   System.Console.WriteLine("первое число большее, а второе меньшее"); 
}
  else
  {
    System.Console.WriteLine("первое число меньшее, а второе большее");
  } 
