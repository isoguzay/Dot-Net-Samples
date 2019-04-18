using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product phone = new Product(50);
            phone.ProductName = "Mobile Phone";
            phone.StockControlEvent += Phone_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                phone.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Warning : Mobile Phone stock is nearly finished.");
        }
    }
}
