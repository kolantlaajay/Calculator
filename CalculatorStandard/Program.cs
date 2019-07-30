using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCalculator;

namespace CalculatorStandard
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCalculator.ArthimeticOperation<int> intOperation = new GenericCalculator.ArthimeticOperation<int>(new IntCalculator());
            Console.WriteLine("Integer Addition: " + intOperation.summation(7, 8));
            Console.WriteLine("Integer Subraction: " + intOperation.subract(8, 7));
            Console.WriteLine("Integer Multiplication: " + intOperation.multiply(8, 7));
            Console.WriteLine("Integer Division: " + intOperation.divide(8, 7));
            Console.WriteLine("Integer multiple addition: " + intOperation.myCalculator.multipleAdd(1, 2, 3, 4, 5));
            Console.WriteLine("\n");
            GenericCalculator.ArthimeticOperation<double> doubleOperation = new GenericCalculator.ArthimeticOperation<double>(new DoubleCalculator());
            Console.WriteLine("Double Addition: " + doubleOperation.summation(7.1, 8.1));
            Console.WriteLine("Double Subraction: " + doubleOperation.subract(8.1, 7.1));
            Console.WriteLine("Double Multiplication: " + doubleOperation.multiply(8.1, 7.1));
            Console.WriteLine("Double Division: " + doubleOperation.divide(8.1, 7.1));
            Console.WriteLine("double multiple addition: " + doubleOperation.myCalculator.multipleAdd(7.2, 3.2, 2.3, 4.2, 1.2));

            Console.ReadKey();
        }
    }
}
