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
   
            Authorisation logowanie = new Authorisation("karol", "321", 3);
            Authorisation logowanie1 = new Authorisation();
            logowanie.login();

            Console.ReadKey();


        }
    }
}
