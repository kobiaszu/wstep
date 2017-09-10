using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class ExtensionExample
    {
        public static Dictionary<string, bool> blackDictonary = new Dictionary<string, bool>()
        {
            { "dupa", true },
            { "dupa1", true },
            { "dupa2", true },
            { "dupa3", true },
            { "dupa4", false }
        };

        public static List<string> blackList = new List<string>()
        {
             "dupa",
             "dupa1",
             "dupa2",
             "dupa3",
             "dupa4"
        };


        public static bool CheckIfBlackDictonary(this string s)
        {
            try
            {
                return blackDictonary[s];
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckIfBlackList(this string s)
        {
            var result = blackList.FirstOrDefault(x => x.Contains(s));
            Console.WriteLine($"ODPALAM CHECK: {result}");

            return result != null ? true : false;
        }


    }
}
