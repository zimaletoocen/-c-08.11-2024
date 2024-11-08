using System;

class Program
{
    static void Main()
    {
        // Упражнение 2.1
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");

        // Упражнение 2.2
        Console.Write("Введите первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());

        try
        {
            int result = num1 / num2;
            Console.WriteLine($"Результат деления {num1} на {num2} равен {result}.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль.");
        }

        // Домашнее задание 2.1
        Console.Write("Введите букву: ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (letter >= 'a' && letter < 'z' || letter >= 'A' && letter < 'Z')
        {
            char nextLetter = (char)(letter + 1);
            Console.WriteLine($"Следующая буква: {nextLetter}");
        }
        else if (letter == 'z')
        {
            Console.WriteLine("Следующая буква: a");
        }
        else if (letter == 'Z')
        {
            Console.WriteLine("Следующая буква: A");
        }
        else
        {
            Console.WriteLine("Ошибка: введённый символ не является буквой.");
        }

        // Домашнее задание 2.2
        Console.WriteLine("Введите коэффициенты квадратного уравнения (ax^2 + bx + c = 0):");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Корни уравнения: x1 = {root1}, x2 = {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: x = {root}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}
