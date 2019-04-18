using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Engin"}, new Customer { FirstName= "Derin"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product: IEntity
    {

    }

    interface IProduct : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomer : IRepository<Customer>
    {
        void Custom();
    }

    interface IStudentDal: IRepository<Student>
    {

    }

    public class Student : IEntity { }
    
    interface IEntity
    {

    }

                                   // where T: struct yazarsak da veri tipi değerlerini alır. 
    interface IRepository<T> where T:class, IEntity, new() // T referans tipi class olmasını istediğimizde, entity tipinde implemente edilebilmeli. 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
    }

    class ProductDal : IProduct
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomer
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

}
