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
}
