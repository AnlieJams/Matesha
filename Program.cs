using System;

class Program
{
    static void Main()
    {
        // Задание 1: В поисках среднего арифметического
        
        #region
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Среднее арифметическое: " + average);
        Console.WriteLine();
        #endregion

        // Задание 2: Кто хочет стать степенью
        #region
        Console.Write("Введите число: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите степень: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
        #endregion

        // Задание 3: Война бесконечности
        #region
        Console.Write("Введите количество гривен: ");
        double amountInHryvnia = Convert.ToDouble(Console.ReadLine());
        double exchangeRateUSD = 0.036; // Курс гривни к доллару
        double exchangeRateEUR = 0.030; // Курс гривни к евро
        double amountInUSD = amountInHryvnia * exchangeRateUSD;
        double amountInEUR = amountInHryvnia * exchangeRateEUR;
        Console.WriteLine("Количество долларов: " + amountInUSD);
        Console.WriteLine("Количество евро: " + amountInEUR);
        Console.WriteLine();
        #endregion

        // Задание 4: Форсаж
        #region
        Console.Write("Введите количество километров: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double landMiles = kilometers * 0.621371; // Сухопутные мили
        double nauticalMiles = kilometers * 0.539957; // Морские мили
        Console.WriteLine("Количество сухопутных миль: " + landMiles);
        Console.WriteLine("Количество морских миль: " + nauticalMiles);
        Console.WriteLine();
        #endregion

        // Задание 5: Ничего оригинального не придумал для названия
        #region
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите процент: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        double resultPercentage = number * (percent / 100);
        Console.WriteLine("Результат: " + resultPercentage);
        #endregion

        // Задание 6: Тупой и ещё Тупее
        #region 
        Console.Write("Введите количество градусов Цельсия: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Температура по шкале Фаренгейта: " + fahrenheit);
        Console.WriteLine();
        #endregion

        #region       
        Console.Write("Введите количество градусов Фаренгейта: ");
        double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
        double celsiusOutput = (fahrenheitInput - 32) * 5 / 9;
        Console.WriteLine("Температура по шкале Цельсия: " + celsiusOutput);
        Console.WriteLine();
        #endregion
    }
}

