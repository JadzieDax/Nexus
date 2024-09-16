using System;

namespace kototest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слагаемое");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите second слагаемое");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Summa chisel равна" + (x+y));

            Console.ReadKey();
        }
    }
}
