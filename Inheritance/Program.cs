using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class LaptopBase
        {
            public const string i3 = "i3";
            public const string i5 = "i5";
            public const string i7 = "i7";
            public const string i9 = "i9";

            public const string Ram2GB = "2GB";
            public const string Ram4GB = "4GB";
            public const string Ram8GB = "8GB";

            public const string HD500GB = "500GB";
            public const string HD1TB = "1TB";

            public const string Price1000 = "$1000";
            public const string Price1500 = "$1500";
            public const string Price2000 = "$2000";

            public const string Lenove = "Lenovo";
            public const string Sony = "Sony";
            public const string Dell = "Dell";
        }

        class laptop: LaptopBase
        {
            public void showdetail(string name, string price, string Processor,string Ram, string HDD)
            {
                Console.WriteLine(name);
                Console.WriteLine(price);
                Console.WriteLine(Processor);
                Console.WriteLine(Ram);
                Console.WriteLine(HDD);
            }
        }

        static void Main(string[] args)
        {
            laptop la = new laptop();
            la.showdetail(laptop.Lenove, laptop.Price1000, laptop.i3, laptop.Ram2GB, laptop.HD500GB);
            la.showdetail(laptop.Dell, laptop.Price1500, laptop.i5, laptop.Ram4GB, laptop.HD1TB);
            Console.ReadKey();
        }
    }
}
