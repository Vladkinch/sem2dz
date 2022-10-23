//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.Write("выходной день");
}
else
{
    Console.Write("не выходной день");
}

