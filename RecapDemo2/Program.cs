﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public ILogger logger { get; set; }

        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer Added");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to FİLE!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
