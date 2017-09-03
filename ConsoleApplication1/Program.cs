using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        

        static void Main(string[] args)
        {


            Console.WriteLine("Siema, podaj swoje imie");
            string name = "";
            while (name == "")
            {
                name = Console.ReadLine();
            }


            int age = 0;
            do
            {
                Console.WriteLine("Podaj wiek: ");
                Int32.TryParse(Console.ReadLine(), out age);
            } while (age <= 0);

            Console.WriteLine($"Jestes {name} i masz {age} lat");


            Console.WriteLine("Tera losowanie");


            Random rnd = new Random();

            int max = sizeof(int), min = sizeof(int);

            bool check = true;
            do
            {
                if (!check)
                    Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz: ");
                else
                    Console.WriteLine("Podaj min: ");
                check = Int32.TryParse(Console.ReadLine(), out min);
            } while ( !min.Equals(sizeof(int)) || !check);

            do
            {
                if (!check)
                    Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz: ");
                else
                    Console.WriteLine("Podaj max: ");
                check = Int32.TryParse(Console.ReadLine(), out max);
            } while (!max.Equals(sizeof(int)) || (max <= min) || !check);

            int p1 = rnd.Next(min, max);
            int p2 = rnd.Next(min, max);

            Console.WriteLine($"wylosowano: {p1} i {p2}, suma wynosi {p1 + p2}");

            Console.ReadKey();




        }
    }
}
