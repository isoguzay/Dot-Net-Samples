using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3] 
            {
                new Customer{FirstName="iso" }, new Student{ Department= "Sayisal"}, new Person{LastName="ay"}
            };
            
            foreach(var person in people)
            {
                Console.WriteLine(person.LastName);
            }

            Console.ReadLine();

        }

        // Bir class sadece bir class a inherit olabilir. Interface kullanımdan ayıran 
        // en önemli özelliklerinden biri. 

        // Inherit edilen class (Person), yeni oluşturulan nesnenin bir classı olarak 
        // kullanılabilir. Interface ler kullanılamaz. 

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
