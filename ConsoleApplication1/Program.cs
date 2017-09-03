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

            //int max = sizeof(int), min = sizeof(int);

            //bool check = true;
            //do
            //{
            //    if (!check)
            //        Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz: ");
            //    else
            //        Console.WriteLine("Podaj min: ");
            //    check = Int32.TryParse(Console.ReadLine(), out min);
            //} while ( min == sizeof(int) || !check);

            //do
            //{
            //    if (!check)
            //        Console.WriteLine("Nie podałeś liczby, spróbuj jeszcze raz: ");
            //    else
            //        Console.WriteLine("Podaj max: ");
            //    check = Int32.TryParse(Console.ReadLine(), out max);
            //} while (max == sizeof(int) || (max < min) || !check);


            //funkcyje.AddRandomNumbers(min, max);

            authorisation logowanie = new authorisation();

            logowanie.login();

            Console.ReadKey();


        }
    }
}
