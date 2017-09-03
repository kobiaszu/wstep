using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class funkcyje
    {
        public static void AddRandomNumbers(object min, object max)
        {
            Random rnd = new Random();
            int p1 = 0, p2 = 0;
            if (min is int)
            {
                p1 = rnd.Next((int)min, (int)max);
                p2 = rnd.Next((int)min, (int)max);
            }
            else
            {
                Console.WriteLine("dupa nie dziala");
            }


            

            Console.WriteLine($"wylosowano: {p1} i {p2}, suma wynosi {p1 + p2}");

            Console.ReadKey();
        }


    }
}
