using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // dictionary bir collection dır.
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","Bilgisayar");

            //Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            // key yada value için arama yapılabilir.
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsValue("Kitap"));

            Console.ReadLine();
        }

        public static void ArrayList()
        {
            ArrayList cities2 = new ArrayList();

            cities2.Add("Ankara");
            cities2.Add("Adana");

            foreach (var item in cities2)
            {
                Console.WriteLine(item);
            }

            cities2.Add("İzmir");
            Console.WriteLine(cities2[2]);

            cities2.Add(1);
            cities2.Add('a');

            foreach (var item in cities2)
            {
                Console.WriteLine(item);
            }

        }

        public static void Array()
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };

            cities = new string[3];

            // yeni referans oluşturulduğunda eski değerini kaybeder.
            //array limiti aşıyor.
            //cities[2] = "Adana";

            Console.WriteLine(cities[0]);
            Console.ReadLine();
        }

        public static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var item in cities)
            {
                //Console.WriteLine(item);
            }

            //List<Customer> customers = new List<Customer>();

            //customers.Add(new Customer
            //{
            //    Id = 1,
            //    FirstName = "iso"
            //});

            //customers.Add(new Customer
            //{
            //    Id = 2,
            //    FirstName = "oguz"
            //});

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="iso"},
                new Customer{Id=2, FirstName = "oguz"}
            };


            var customer = new Customer
            {
                Id = 3,
                FirstName = "isoguz"
            };

            customers.Add(customer);

            customers.AddRange(new Customer[2] {
                new Customer{Id=4,FirstName="james"},
                new Customer{Id=5, FirstName = "jones"}
            });

            //customers.Clear();

            //customers.Contains();

            // index of bastan başlayıp indexi verir
            var index = customers.IndexOf(customer);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer);

            // sondan başlayıp index verir.
            var lastIndex = customers.LastIndexOf(customer);
            Console.WriteLine("Index : {0}", lastIndex);

            customers.Insert(0, customer);
            customers.Insert(0, customer);
            customers.Insert(0, customer);

            customers.Remove(customer);

            customers.RemoveAll(c => c.FirstName == "iso");

            var counter = 0;
            foreach (var item in customers)
            {
                counter++;
                Console.WriteLine(counter + ") " + item.FirstName);
            }

            Console.WriteLine(customers.Contains(customer));

            var count = customers.Count;
            Console.WriteLine("Count {0}", count);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
