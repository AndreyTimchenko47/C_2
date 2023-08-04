// Написать программу, которая на вход принимает число и выдаёт его квадрат
Console.WriteLine("Введите  число");

int number = Convert.ToInt32(Console.ReadLine());

int count = number * number;
Console.WriteLine($"Квадрат числа {number} = {count}"); // $ - интерполирует переменную в число
