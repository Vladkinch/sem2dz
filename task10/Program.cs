// напишите программу, которая принимает на ввод трехзначное число и на выходе показывает вторую цифру этого числа

bool Second (string? number)
{
    bool result = int.TryParse(number, out int num);
    result = num > 99 ? true : false;
    return result;
}

Console.Write("Введите трехзначное число: ");
string? number = Console.ReadLine();

while (!Second(number) || number.Length != 3)
{
    Console.Write("Вы ввели не трехзначное число. Попробуйте снова: ");

    number = Console.ReadLine();
}

Console.WriteLine($"Вторая цифра числа: {number[1]}");
