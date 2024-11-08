using System;

class Zadachi
{
    static void Main(string[] args)
    {  // задача намбер 1: вывод числа e с точностью до десятых
        Console.WriteLine($"Число e: {Math.E:F1}");

        // задача намбер 2: вывод чисел 50 и 10 одно под другим
        Console.WriteLine("50\n10");

        // задача намбер 3: вывод четырех чисел столбиком
        Console.WriteLine("1\n2\n3\n4");

        // задача намбер 4: Ввод числа пользователем и вывод числа +10
        Console.Write("Введите число: ");
        int userInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число больше на 10: {userInput + 10}");

        // задача намбер 5: Найти периметр квадрата
        Console.Write("Введите сторону квадрата: ");
        double side = double.Parse(Console.ReadLine());
        double perimeter = 4 * side;
        Console.WriteLine($"Периметр квадрата: {perimeter}");

        // задача намбер 6: Найти длину окружности и площадь круга
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Длина окружности: {circumference}, Площадь круга: {area}");

        // задача намбер7: Найти значение y=cos(x)
        Console.Write("Введите x для поиска cos(x): ");
        double x = double.Parse(Console.ReadLine());
        double y = Math.Cos(x);
        Console.WriteLine($"cos({x}) = {y}");

        // задача намбер 8: Периметр равнобедренной трапеции
        Console.Write("Введите основания (a и b) и высоту h равнобедренной трапеции: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double sideLength = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));
        double perimeterTrapezium = a + b + 2 * sideLength;
        Console.WriteLine($"Периметр равнобедренной трапеции: {perimeterTrapezium}");

        // задача намбер9: Стоимость всей покупки
        Console.Write("Введите стоимость 1 кг конфет, печенья, яблок и количество кг каждой: ");
        double candyPrice = double.Parse(Console.ReadLine());
        double cookiePrice = double.Parse(Console.ReadLine());
        double applePrice = double.Parse(Console.ReadLine());
        double xCandy = double.Parse(Console.ReadLine());
        double yCookie = double.Parse(Console.ReadLine());
        double zApple = double.Parse(Console.ReadLine());
        double totalCost = (candyPrice * xCandy) + (cookiePrice * yCookie) + (applePrice * zApple);
        Console.WriteLine($"Общая стоимость покупки: {totalCost}");

        //задача намбер10: Вывести три строки
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир\nТруд\nМай");

        // задача намбер 11: Поменять местами 2 числовые переменные
        double aVariable, bVariable;
        Console.Write("Введите первое число: ");
        while (!double.TryParse(Console.ReadLine(), out aVariable))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
        }

        Console.Write("Введите второе число: ");
        while (!double.TryParse(Console.ReadLine(), out bVariable))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
        }

        // меняем местами
        (aVariable, bVariable) = (bVariable, aVariable);
        Console.WriteLine($"Первое число: {aVariable}, Второе число: {bVariable}");
        // задача намбер 12: Подсчет периметра и площади фигур
        Console.WriteLine("Выберите фигуру: 1) Треугольник 2) Четырехугольник 3) Круг");
        int shapeChoice = int.Parse(Console.ReadLine());

        if (shapeChoice == 1) // Треугольник
        {
            Console.Write("Введите три стороны треугольника: ");
            double aTriangle = double.Parse(Console.ReadLine());
            double bTriangle = double.Parse(Console.ReadLine());
            double cTriangle = double.Parse(Console.ReadLine());
            double perimeterTriangle = aTriangle + bTriangle + cTriangle;
            double s = perimeterTriangle / 2;
            double areaTriangle = Math.Sqrt(s * (s - aTriangle) * (s - bTriangle) * (s - cTriangle));
            Console.WriteLine($"Периметр треугольника: {perimeterTriangle}, Площадь: {areaTriangle}");
        }
        else if (shapeChoice == 2) // Четырехугольник
        {
            Console.Write("Введите длины сторон четырехугольника: ");
            double aQuad = double.Parse(Console.ReadLine());
            double bQuad = double.Parse(Console.ReadLine());
            double cQuad = double.Parse(Console.ReadLine());
            double dQuad = double.Parse(Console.ReadLine());
            double perimeterQuad = aQuad + bQuad + cQuad + dQuad;
            Console.WriteLine($"Периметр четырехугольника: {perimeterQuad}");
            // Площадь можно считать по формуле, например, для прямоугольника
            double areaQuad = aQuad * bQuad; // если брать только прямоугольник
            Console.WriteLine($"Площадь: {areaQuad}");
        }
        else if (shapeChoice == 3) // Круг
        {
            Console.Write("Введите радиус круга: ");
            double radiusCircle = double.Parse(Console.ReadLine());
            double perimeterCircle = 2 * Math.PI * radiusCircle;
            double areaCircle = Math.PI * radiusCircle * radiusCircle;
            Console.WriteLine($"Длина окружности: {perimeterCircle}, Площадь круга: {areaCircle}");
        }

        // задача намбер 13: Вывод введенного с клавиатуры числа
        Console.Write("Введите число для вывода: ");
        double userNumber = double.Parse(Console.ReadLine());
        Console.WriteLine($"Вы ввели число: {userNumber}");

        //задача намбер 14: Вывод информации
        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");

        // задача намбер 15: Вывод четырех случайных чисел столбиком
        Random random = new Random();
        Console.WriteLine($"{random.Next(1, 101)}\n{random.Next(1, 101)}\n{random.Next(1, 101)}\n{random.Next(1, 101)}");

        // задача намбер 16: программа решает кв-ое ур-ие
        Console.Write("Введите коэффициент a: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент b: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент c: ");
        double g = Convert.ToDouble(Console.ReadLine());

        double discriminant = f * f - 4 * d * g;

        if (discriminant > 0)
        {
            double root1 = (-f + Math.Sqrt(discriminant)) / (2 * d);
            double root2 = (-f - Math.Sqrt(discriminant)) / (2 * d);
            Console.WriteLine($"Корни уравнения: {root1} и {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -f / (2 * d);
            Console.WriteLine($"Корень уравнения: {root}");
        }
        else
        {
            Console.WriteLine("Корней нет.");
        }

        // задача намбер 17: программа решает кв-ое ур-ие

        Console.Write("Введите первое число: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int m = Convert.ToInt32(Console.ReadLine());

        double arithmeticMean = (k + m) / 2.0;
        double geometricMean = Math.Sqrt(k * m);

        Console.WriteLine($"Среднее арифметическое: {arithmeticMean}");
        Console.WriteLine($"Среднее геометрическое: {geometricMean}");

        // задача намбер 18: узнать расстояние между двумя точками

        Console.Write("Введите координаты первой точки (x1, y1): ");
        string[] point1 = Console.ReadLine().Split(',');
        double x1 = Convert.ToDouble(point1[0]);
        double y1 = Convert.ToDouble(point1[1]);

        Console.Write("Введите координаты второй точки (x2, y2): ");
        string[] point2 = Console.ReadLine().Split(',');
        double x2 = Convert.ToDouble(point2[0]);
        double y2 = Convert.ToDouble(point2[1]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между точками: {distance}");

        //задача намбер 19: обмен значениями переменных

        int a1, b1, c1;

        Console.Write("Введите значение a: ");
        a1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b: ");
        b1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение c: ");
        c1 = Convert.ToInt32(Console.ReadLine());

        // Схема а
        (b1, c1, a1) = (c1, a1, b1);
        Console.WriteLine($"Схема а: a={a1}, b={b1}, c={c1}");

        // Схема б
        (a1, b1, c1) = (b1, c1, a1);
        Console.WriteLine($"Схема б: a={a1}, b={b1}, c={c1}");

        // задача намбер 20: определение времени по секундам
        Console.Write("Введите количество секунд с начала суток: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int hours = n / 3600;
        int minutes = (n % 3600) / 60;
        int seconds = n % 60;

        Console.WriteLine($"Полные часы: {hours}, полные минуты: {minutes}, полные секунды: {seconds}");

        // задача намбер 21: Квадраты из прямоугольника
        int rectangleWidth = 543;
        int rectangleHeight = 130;

        int squareSide = 130;

        int squaresCount = (rectangleWidth / squareSide) * (rectangleHeight / squareSide);

        Console.WriteLine($"Количество квадратов со стороной {squareSide} мм: {squaresCount}");

        // задача намбер 22: Перестановка цифр трехзначного числа

        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int lastDigit = number % 10;
        int newNumber = lastDigit * 100 + number / 10;

        Console.WriteLine($"Полученное число: {newNumber}");

        // задача намбер 23: Число сотен и тысяч в числе n

        Console.Write("Введите натуральное число n (n > 999): ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        int hundreds = (n1 / 100) % 10;
        int thousands = (n1 / 1000) % 10;

        Console.WriteLine($"Число сотен: {hundreds}, число тысяч: {thousands}");

        // задача намбер 24: Перестановка цифр четырехзначного числа

        Console.Write("Введите четырехзначное число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // а) Число, полученное при прочтении справа налево
        int reverseNumber = (number1 % 10) * 1000 + (number1 / 10 % 10) * 100 + (number1 / 100 % 10) * 10 + (number1 / 1000);

        // б) Перестановка первой и второй, третьей и четвертой цифр
        int swapFirstSecond = (number1 % 1000 / 100) * 1000 + (number1 % 10000 / 1000) * 100 + (number1 % 10) * 10 + (number1 / 100 % 10);

        // в) Перестановка второй и третьей цифр
        int swapSecondThird = (number1 / 1000) * 1000 + (number1 % 1000 / 100) * 10 + (number1 % 10) * 100 + (number1 / 100 % 10);

        // г) Перестановка двух первых и двух последних цифр
        int swapFirstLastTwo = (number1 % 10000 / 100) * 1000 + (number1 % 100000 / 10000) * 100 + (number1 % 1000 / 100) * 10 + (number1 / 10000);

        Console.WriteLine($"Число, прочитанное справа налево: {reverseNumber}");
        Console.WriteLine($"Перестановка первой и второй, третьей и четвертой цифр: {swapFirstSecond}");
        Console.WriteLine($"Перестановка второй и третьей цифр: {swapSecondThird}");
        Console.WriteLine($"Перестановка двух первых и двух последних цифр: {swapFirstLastTwo}");

        // задача намбер 25: Найти число x по условию задачи

        Console.Write("Введите число n (100 ≤ n ≤ 999): ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        for (int x3 = 100; x3 <= 999; x3++)
        {
            int lastDigitbro = x3 % 10;
            if ((x - lastDigitbro) / 10 == n2)
            {
                Console.WriteLine($"Найдено число x: {x3}");
                break;


            }


        }

        // задача намбер 26: Угол между часовыми стрелками
        Console.Write("Введите часы (0-23): ");
        int h1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минуты (0-59): ");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите секунды (0-59): ");
        int s1 = Convert.ToInt32(Console.ReadLine());

        double hourAngle = (h1 % 12 + m1 / 60.0 + s1 / 3600.0) * 30; // каждый час - это 30 градусов
        double minuteAngle = (m1 + s1 / 60.0) * 6; // каждая минута - это 6 градусов

        double angleBetweenHands = Math.Abs(hourAngle - minuteAngle);

        if (angleBetweenHands > 180)
            angleBetweenHands = 360 - angleBetweenHands;

        Console.WriteLine($"Угол между стрелками: {angleBetweenHands} градусов");


        //задача намбер 27: Угол для минутной стрелки и количество полных часов и минут

        Console.Write("Введите часы (0-23): ");
        int hhh = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минуты (0-59): ");
        int mmm = Convert.ToInt32(Console.ReadLine());

        double minuteAngleMeow = m * 6; // каждая минута - это 6 градусов

        Console.WriteLine($"Угол для минутной стрелки: {minuteAngleMeow} градусов");

        // задача намбер 28: Меньшее по модулю из трех вещественных чисел

        double[] numbers = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double minAbsValue = Math.Abs(numbers[0]);
        foreach (double num in numbers)
        {
            if (Math.Abs(num) < minAbsValue)
                minAbsValue = Math.Abs(num);
        }

        Console.WriteLine($"Меньшее по модулю из введенных чисел: {minAbsValue}");


        //задача намбер 29:  Сумма большего и меньшего из трех чисел

        double[] numbers1 = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxxNum = numbers1[0];
        double minnNum = numbers1[0];

        foreach (double num in numbers1)
        {
            if (num > maxxNum)
                maxxNum = num;
            if (num < minnNum)
                minnNum = num;
        }

        double summa = maxxNum + minnNum;
        Console.WriteLine($"Сумма большего и меньшего из введенных чисел: {summa}");


        //задача намбер 30: Сумма большего и меньшего из трех чисел
        Console.Write("Введите натуральное число: ");
        int j = Convert.ToInt32(Console.ReadLine());

        int countDivisors = 0;

        for (int i = 1; i <= j; i++)
        {
            if (n % i == 0)
                countDivisors++;
        }

        Console.WriteLine($"Количество делителей числа {n}: {countDivisors}");

        //задача намбер 31: Поиск корней кубического уравнения методом перебора

        Console.Write("Введите коэффициенты A, B, C, D для уравнения Ax^3 + Bx^2 + Cx + D = 0:nA: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        Console.Write("D: ");
        int D = Convert.ToInt32(Console.ReadLine());

        for (int x0 = -100; x0 <= 100; x0++)
        {
            if (A * x0 * x0 * x0 + B * x0 * x0 + C * x0 + D == 0)
            {
                Console.WriteLine($"Найден корень кубического уравнения: x0={x0}");
            }
        }


        // задача намбер 32: Элемент арифметической прогрессии по номеру

        Console.Write("Введите первый элемент прогрессии a1: ");
        double a01 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второй элемент прогрессии a2: ");
        double a02 = Convert.ToDouble(Console.ReadLine());

        double d0 = a02 - a01; // разность прогрессии

        Console.Write("Введите номер элемента прогрессии n: ");
        int n0 = Convert.ToInt32(Console.ReadLine());

        double an0 = a01 + (n0 - 1) * d0;
        Console.WriteLine($"Элемент прогрессии под номером {n0}: {an0}");

        // задача намбер 33: условия получения кредита

        bool isPensioner, isStudent;

        Console.Write("Вы пенсионер? (да/нет): ");
        isPensioner = Console.ReadLine().ToLower() == "да";

        Console.Write("Вы студент? (да/нет): ");
        isStudent = Console.ReadLine().ToLower() == "да";

        if ((isPensioner && !isStudent) || (!isPensioner && !isStudent))
            Console.WriteLine("Кредит будет выдан.");
        else if (isPensioner && isStudent)
            Console.WriteLine("Кредит не будет выдан.");
        else
            Console.WriteLine("Кредит не будет выдан.");

        // задача намбер 34: вывод на экран имени и имени с приветствием

        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        Console.WriteLine($"Привет, {name}!");

        // задача намбер 35: разговор с консолью

        Console.WriteLine("Привет! Как тебя зовут?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Привет, {userName}!");

        Console.WriteLine("Ты знаешь что-то о тайной комнате?");
        Console.WriteLine("Консоль отвечает: Да.");

        Console.WriteLine("Можешь рассказать?");
        Console.WriteLine("Консоль отвечает: Нет.");

        // Ждем 5 секунд перед следующим сообщением
        Thread.Sleep(5000);
        Console.WriteLine("Но могу показать.");

        // Меняем цвет текста на случайный
        Random random00 = new Random();
        Console.ForegroundColor = (ConsoleColor)random00.Next(1, 16); // Случайный цвет
        Console.WriteLine("Вот что я могу показать!");

        // Возвращаем цвет текста к стандартному
        Console.ResetColor();

        // задача 36: вычисление контрольной цифры штрихкода EAN-13

        Console.WriteLine("Введите 12 цифр штрихкода EAN-13:");
        string input = Console.ReadLine();

        if (input.Length != 12 || !long.TryParse(input, out _))
        {
            Console.WriteLine("Ошибка: введите ровно 12 цифр.");
            return;
        }

        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            if (i % 2 == 0) // Четные индексы
            {
                sumOdd += digit;
            }
            else // Нечетные индексы
            {
                sumEven += digit;
            }
        }

        int totalSum = sumOdd + (sumEven * 3);
        int checkDigit = (10 - (totalSum % 10)) % 10;

        Console.WriteLine($"Контрольная цифра штрихкода EAN-13: {checkDigit}");




    }
}