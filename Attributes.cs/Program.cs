using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Oguz", Age = 27 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    //this model uses for dynamic models
  //  [ToTable("Customers")]
   // [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        // Attributes uses for creating rules your business.
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        //[RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        // this attribute uses for same methods using conditions
        [Obsolete("Don't use Add instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    // Using area declare there for instance : property, class or all areas. 
    // add more using area using with pipe.
    // Allow multiple uses for using one or more.
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }


    //Send a parameter to Attribute
    [AttributeUsage(AttributeTargets.Property, AllowMultiple =true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
    
}
