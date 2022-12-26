
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