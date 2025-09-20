using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину первого катета:");
        double cathetus1 = ReadPositiveDouble();

        Console.WriteLine("Введите длину второго катета:");
        double cathetus2 = ReadPositiveDouble();

        double area = (cathetus1 * cathetus2) / 2;
        double hypotenuse = Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2);
        double perimeter = cathetus1 + cathetus2 + hypotenuse;

        Console.WriteLine($"Площадь прямоугольного треугольника: {area}");
        Console.WriteLine($"Периметр прямоугольного треугольника: {perimeter}");
    }

    static double ReadPositiveDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите положительное число.");
            }
        }
    }
}
