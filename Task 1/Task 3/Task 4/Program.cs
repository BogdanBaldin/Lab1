uint oddNumberCount = 0; 
uint evenNumberCount = 0;

System.Console.WriteLine("Введите первое число диапозона");
int  currentValue = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите последнее число диапозона");
int limit = int.Parse(Console.ReadLine());

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        evenNumberCount++;
    }
    else
    {
        oddNumberCount++;
    }
    currentValue++;
}

System.Console.WriteLine("Количество нечетных чисел");
System.Console.WriteLine("Количество четных чисел");
Console.ReadLine();