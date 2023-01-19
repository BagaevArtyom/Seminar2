// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console. Clear();
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 0 && number < 6)
    {
        Console. WriteLine("Рабочий день");
    }
else if (number > 5 && number <8)
    {
        Console.WriteLine("Выходной");
    }