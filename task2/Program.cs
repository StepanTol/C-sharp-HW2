Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!); 
if (a<100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while(a>=1000)
    {
    a = a/10;    
    }
    int b = a%10;
    Console.WriteLine($"Третья цифра числа: " + b);
}