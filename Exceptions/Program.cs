using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }
            
            // bir methoda method göndermek için delegeler kullanılır.
            HandleException(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static void Find()
        {
            List<string> students = new List<string> { "İso", "Oguz", "İsoguz" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found ! ");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }

        public static void ErrorInfo()
        {
            try
            {
                string[] student = new string[3]
                {
                    "İso","Oguz","İsoguz"
                };
                // upperbound değeri 2 olduğu için hata verir.
                student[3] = "Ali";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Expection : " + exception.Message + " Detail : " + exception.InnerException);
                throw;
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Expection : " + exception.Message + " Detail : " + exception.InnerException);
                throw;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Expection : " + exception.Message + " Detail : " + exception.InnerException);
                throw;
            }

        }

    }
}
