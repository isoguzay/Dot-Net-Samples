using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation(7,9);
            calculation.Multip(7,8);
            calculation.Multip2();
            
        }
    }

    public class Calculation
    {

        private int _num1;
        private int _num2;

        public Calculation(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multip(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Sum2()
        {
            return _num1 + _num2;
        }

        public int Multip2()
        {
            return _num1 * _num2;
        }

    }
}
