using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace UchebProgramm
{
    class Program
    {
        private static double sum;
        private static double min, max;

        static bool isFirst = true;

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Вы не указали числа! Пожалуйста, укажите их!");
                Console.WriteLine("Указать нужно к примеру таким образом: dotnet run -- 5 15 10");
                return;
            }
            
            Console.WriteLine("Числа: "+ string.Join(", ", args));
            foreach (string i in args)
            {
                if (double.TryParse(i, out double number))
                {
                    sum += number;

                    if (isFirst)
                    {
                        min = number;
                        max = number;
                        isFirst = false;
                    }
                    else
                    {
                        if (number > max) max = number;
                        if (number < min) min = number;
                    }
                }
            }
            
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее арифметическое: {(sum / args.Length):F2}");
            Console.WriteLine($"Минимальное число: {min}");
            Console.WriteLine($"Максимальное число: {max}");
        }
    }
}
