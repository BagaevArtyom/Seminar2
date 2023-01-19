       // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево)
        Console.Clear();
        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 100 && number > -100)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            int result = number / 100 % 10;
            Console.WriteLine($"Третья цифра: {result}");
        }