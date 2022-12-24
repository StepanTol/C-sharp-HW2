Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a<6)
{
    Console.WriteLine("Нет");
}
else
{
    if (a>5 & a<8)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Неверная цифра");
    }    
}
