using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierss
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private string Name { get; set; }
        protected int Id { get; set; }

        public void Save()
        {
           
        }

        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save2()
        {
            
        }
    }

    // bir classın default değeri, aynı assembly içinde kullanılabilir.
    // üst düzey bir class private yada protected olamaz.
    // iç içe class larda private yapısı kullanılabilir.
    internal class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }

    //public yapısı diğer projelerde de kullanılabilir.
    // proje referans olarak eklenir.

    public class Lesson
    {

    }
}
