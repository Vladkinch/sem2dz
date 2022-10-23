//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число > 99: ");
string number = Console.ReadLine();
if (number.Length >= 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.Write("Третьей цифры нет в числе");
}
