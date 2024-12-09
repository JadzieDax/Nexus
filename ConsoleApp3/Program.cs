using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            if (!TryInputNumber("Введите перый член прогрессии ", out b))
            {
                Console.ReadKey();
                return;
            }

            double q = 0;
            if (!TryInputNumber("Введите знаменатель прогрессии", out q))
            {
                Console.ReadKey();
                return;
            }

            var numbers = new double[20];
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = b * Math.Pow(q, i);
            }
            PrintArray(numbers);

            Console.ReadKey();
        }
        static bool TryInputNumber(string message, out double number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
        static void PrintArray(double[] array) 
        {
            foreach (var element in array)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }
    }
}
