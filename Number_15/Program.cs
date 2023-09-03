Console.WriteLine("Введите день недели (Понидельник - 1 и т.д)");
int day_week = Convert.ToInt32(Console.ReadLine());
if (day_week >= 1 && day_week <= 7 )
{
    if (day_week >= 1 && day_week <= 5)
    {
        Console.WriteLine($"{day_week} -> Рабочий день недели");
    }
    else 
    {
        Console.WriteLine($"{day_week} -> Выходной день недели");
    }
}
else 
{
    Console.WriteLine($"{day_week} -> нет такого дня недели");
}
