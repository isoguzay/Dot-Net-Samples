using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Adana" };
            cities2 = cities1;

            cities1[0] = "Istanbul";

            Console.WriteLine(cities2[0]);

            // new işleminden kaçınmalıyız.
            // new işlemi bellekte yer tutar.
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();

            DataTable dataTable3;
            DataTable dataTable4 = new DataTable();

            dataTable3 = dataTable4;

            dataTable2 = dataTable1;

            Console.ReadLine();
        }
    }
}
