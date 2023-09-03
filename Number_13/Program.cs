// программа выводящие 3 цифру из любого числа
Console.WriteLine("Введите число");
string string_number = Console.ReadLine();
int count = 0;
char[] arr;
if (double.TryParse(string_number, out double number))
{
    arr = string_number.ToCharArray(0, string_number.Length);
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= '0' && arr[i] <= '9')
        {
            count++;
        }
        if (count == 3)
        {
            Console.WriteLine($"{string_number} -> {arr[i]}");
            break;
        }
    }
    if (count < 3)
    {
        Console.WriteLine($"{string_number} -> тут нет третьего числа");
    }
}
else 
{
    Console.WriteLine("Это не являиться числом");
}