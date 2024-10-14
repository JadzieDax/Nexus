using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("перемена");

            var s = "перемена";
            var word1 = s
                .Remove(6)
                .Remove(0, 4);
            word1 += s.Substring(2, 1);
            word1 += s.Substring(7, 1);

            Console.WriteLine(word1);
            

            var word2 = s
                .Remove(7)
                .Remove(0, 6);
                word2 += s.Substring(1, 2);
                word2 += s.Substring(0,1);
                word2 += s.Substring(7,1);

                Console.WriteLine(word2);
                Console.ReadKey();


        }
    }
}
