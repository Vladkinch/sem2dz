// напишите программу, которая принимает на ввод трехзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
string? number = Console.ReadLine();

while (number.Length != 3)
{
    Console.Write("Вы ввели не трехзначное число. Попробуйте снова: ");

    number = Console.ReadLine();
}

Console.WriteLine($"Вторая цифра числа: {number[1]}");
 