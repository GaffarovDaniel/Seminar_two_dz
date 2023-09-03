Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (100 > number || number > 1000)
{
    Console.WriteLine("Это не трехзначеное число");
}
else 
{
    Console.WriteLine($"{number} -> {(number / 10) % 10}");
}
