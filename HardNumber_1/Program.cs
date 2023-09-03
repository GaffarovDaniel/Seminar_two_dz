string string_number = Console.ReadLine();
string clone_string_number = string_number; // для красивого вывода
int count = 0;
if (double.TryParse(string_number, out double number)) // проверка являиться ли строка числом
{
    for (int i = 0; i < string_number.Length; i++)
    {
        if (string_number[i] >= '0' && string_number[i] <= '9' )
        {
            count++;
        }
        if (count == 2)
        {
           string_number = string_number.Replace(string_number[i], ' ');
           string_number = string_number.Replace(" ", "");
           break;
        }
    }
    Console.WriteLine($"{clone_string_number} -> {string_number}");
}
else
{
    Console.WriteLine("Это не число");
}