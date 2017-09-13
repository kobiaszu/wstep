using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Car
    {

        protected string CarColor;

        protected string Brand;

        protected uint EngineCapacity;

        public abstract void PrintCarColor();

        public abstract void PrintBrand();

        public abstract void PrintEngineCapacity();

    }

    public class Ford : Car
    {
        public Ford()
        {
            CarColor = "czerwony";

            Brand = "Ford";

            EngineCapacity = 2500;
        }

        public override void PrintCarColor()
        {
            Console.WriteLine($"Kolor samochodu to {CarColor}");
        }

        public override void PrintBrand()
        {
            Console.WriteLine($"Marka samochodu to {CarColor}");
        }

        public override void PrintEngineCapacity()
        {
            Console.WriteLine($"Pojemność wynosi {CarColor}");
        }
    }
}
