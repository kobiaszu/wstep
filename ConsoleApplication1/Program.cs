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

            //Authorisation logowanie = new Authorisation("karol", "321", 3);
            //Authorisation logowanie1 = new Authorisation();
            //logowanie.login();

            string check = "dupen";
            string result = "";

            if (ExtensionExample.CheckIfBlackDictonary(check))
            {
                result = "jest na slowniku :)";
            }
            else
            {
                result = "nie ma na slowniku :(";
            }

            Console.WriteLine($"Result for 'dupen': {result}");

            ExtensionExample.blackDictonary.Add(check, true);

            if (ExtensionExample.CheckIfBlackDictonary(check))
            {
                result = "jest na slowniku :)";
            }
            else
            {
                result = "nie ma na slowniku :(";
            }

            Console.WriteLine($"Result for 'dupen': {result}");

            // TERA LISTA



            if (ExtensionExample.CheckIfBlackList(check))
            {
                result = "jest na liscie :)";
            }
            else
            {
                result = "nie ma na liście :(";
            }

            Console.WriteLine($"Result for 'dupen': {result}");

            ExtensionExample.blackList.Add(check);

            if (ExtensionExample.CheckIfBlackList(check))
            {
                result = "jest na liscie :)";
            }
            else
            {
                result = "nie ma na liście :(";
            }

            Console.WriteLine($"Result for 'dupen': {result}");


            Console.ReadKey();


        }
    }
}
