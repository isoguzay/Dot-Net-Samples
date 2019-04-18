using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database db2 = new SqlServer();
            db2.Add();
            db2.Delete();

            Console.ReadLine();
        }
    }

    // abstract classları inheritance eden classlar abstract sınıfların methodlarını alırlar.
    // Add methodu herkes için ayı iken delete methodu değiştirilebilir.
    // abstract classlar new lenemez. 

    abstract class Database
    {
        // tamamlanmış method
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        // tamamlanmamış method
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Delete by SQL");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Delete by Oracle");
        }
    }
}
