using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double h;

            Console.WriteLine("Введите число дюймов - верхнюю границу таблицы ");
            if (!double.TryParse(Console.ReadLine(), out a) & a < 0)
            {
                Console.WriteLine("Ошибка. Введенные данные должны быть положительным числом");
            };

            Console.WriteLine("Введите число - размер шага в дюймах");
            if (!double.TryParse(Console.ReadLine(), out h) & h < 0)
            {
                Console.WriteLine("Ошибка. Введенный размер шага должен быть положительным числом");
            };

            Console.WriteLine("Таблица перевода:");
            for (double inches = 1; inches <= a; inches +=h)
            {
                double centimetres = inches * 2.54;
                Console.WriteLine($"{inches:F2} дюймов: {centimetres:F2} см");
            }
            Console.ReadKey();
        }
    }
}
