using System;

namespace SF_10._5
{
    class Program
    {
        static double InputNumbers(int n)
        {
            Logger Logger = new Logger();
            try
            {
                Logger.Event($"Введите чнсло {n}:\t");
                return double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Logger.Error($"Ошибка: {ex.Message} Введите корректное число");

                return InputNumbers(n);
            }
        }
        static void Main()
        {
            while (true)
            {
                ICalculator calculator = new Calculator(InputNumbers(1), InputNumbers(2));
                calculator.Calculate();
            }
        }

    }
}
